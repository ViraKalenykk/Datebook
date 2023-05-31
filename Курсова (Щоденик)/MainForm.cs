using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Курсова__Щоденик_.Model;

namespace Курсова__Щоденик_
{
    public partial class MainForm : Form
    {
        private BindingList<Event> EventList = new BindingList<Event>();

        private bool IsDragging = false;
        private Point DragStartPosition;
        private DateTime selectedDate;

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;

            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:00";
            DateTimePicker.ShowUpDown = true;
            DateTimePickerTill.Format = DateTimePickerFormat.Custom;
            DateTimePickerTill.CustomFormat = "dd/MM/yyyy HH:mm:00";
            DateTimePickerTill.ShowUpDown = true;

            Table.DataSource = EventList;

            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;

            Table.Columns["isDone"].HeaderText = "Стан";
            Table.Columns["name"].HeaderText = "Назва";
            Table.Columns["datetime"].HeaderText = "Дата та час";
            Table.Columns["datetimetill"].HeaderText = "Тривалість (до)";
            Table.Columns["place"].HeaderText = "Місце проведення";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "isDone";
            checkBoxColumn.HeaderText = "Стан";
            checkBoxColumn.Name = "isDone";
            checkBoxColumn.ReadOnly = false;
            Table.Columns.Remove("isDone");
            Table.Columns.Insert(0, checkBoxColumn);
            Table.CellContentClick += Table_CellContentClick;

            LoadEventsFromJson();

            Table.SelectionChanged += Table_SelectionChanged;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDragging = true;
                DragStartPosition = e.Location;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                Point diff = Point.Subtract(e.Location, new Size(DragStartPosition));
                this.Location = Point.Add(this.Location, new Size(diff));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void SaveEventsToJson()
        {
            string json = JsonConvert.SerializeObject(EventList);
            File.WriteAllText("events.json", json);
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                EventList = JsonConvert.DeserializeObject<BindingList<Event>>(json);
            }

            if (selectedDate != DateTime.MinValue)
            {
                var filteredEvents = EventList.Where(ev => ev.DateTime.Date == selectedDate).ToList();
                filteredEvents.Sort((ev1, ev2) => ev1.DateTime.CompareTo(ev2.DateTime));
                BindingList<Event> sortedEventList = new BindingList<Event>(filteredEvents);
                Table.DataSource = sortedEventList;
            }
            else
            {
                var sortedEvents = EventList.OrderBy(ev => ev.DateTime).ToList();
                BindingList<Event> sortedEventList = new BindingList<Event>(sortedEvents);
                Table.DataSource = sortedEventList;
            }
        }

        private Event GetNextEvent()
        {
            Event nextEvent = null;
            DateTime currentTime = DateTime.Now;

            foreach (Event ev in EventList)
            {
                if (ev.DateTime >= currentTime && (nextEvent == null || ev.DateTime < nextEvent.DateTime))
                {
                    nextEvent = ev;
                }
            }
            return nextEvent;
        }

        private void ShowNextEventReminder()
        {
            Event nextEvent = GetNextEvent();

            if (nextEvent != null)
            {
                TimeSpan timeRemaining = nextEvent.DateTime - DateTime.Now;

                timeRemaining = new TimeSpan((long)Math.Round((double)timeRemaining.Ticks, MidpointRounding.AwayFromZero));

                int days = timeRemaining.Days;
                int hours = timeRemaining.Hours;
                int minutes = timeRemaining.Minutes;

                string formattedTimeRemaining = "";
                if (days > 0)
                {
                    formattedTimeRemaining += $"{days} {(days == 1 ? "день" : "дні")} ";
                }
                if (hours > 0)
                {
                    formattedTimeRemaining += $"{hours} {(hours == 1 ? "година" : "годин")} ";
                }
                if (minutes > 0)
                {
                    formattedTimeRemaining += $"{minutes} {(minutes == 1 ? "хвилина" : "хвилин")}";
                }

                MessageBox.Show($"Найближча подія: {nextEvent.Name}\nДата та час: {nextEvent.DateTime}\nЗалишилося часу:" +
                    $" {formattedTimeRemaining}", "Нагадування");
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            ShowNextEventReminder();
        }

        private bool CheckEventOverlapChange(Event newEvent)
        {
            foreach (Event existingEvent in EventList)
            {
                if (existingEvent == Table.SelectedRows[0].DataBoundItem)
                    continue;

                if (newEvent.DateTime < existingEvent.DateTimeTill && newEvent.DateTime != existingEvent.DateTimeTill  
                    && newEvent.DateTimeTill > existingEvent.DateTime && newEvent.DateTimeTill != existingEvent.DateTime)
                {
                    return true; // Є накладання подій
                }
            }
            return false; // Немає накладання подій
        }

        private bool CheckEventOverlapAdd(Event newEvent)
        {
            foreach (Event existingEvent in EventList)
            {
                if (newEvent.DateTime < existingEvent.DateTimeTill && newEvent.DateTime != existingEvent.DateTimeTill  
                    && newEvent.DateTimeTill > existingEvent.DateTime && newEvent.DateTimeTill != existingEvent.DateTime)
                {
                    return true; // Є накладання подій
                }
            }
            return false; // Немає накладання подій
        }


        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Table.Columns["isDone"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)Table.Rows[e.RowIndex].Cells["isDone"];
                bool currentStatus = (bool)checkBoxCell.Value;
                checkBoxCell.Value = !currentStatus;

                Event selectedEvent = EventList[e.RowIndex];
                selectedEvent.IsDone = !currentStatus;
                SaveEventsToJson();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string eventName = textName.Text.Trim();
            DateTime eventDateTime = DateTimePicker.Value;
            DateTime eventDateTimeTill = DateTimePickerTill.Value;
            string eventPlace = textPlace.Text.Trim();

            // Перевірити, чи всі поля заповнені
            if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(eventPlace))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірити коректність дат та часу
            if (eventDateTime >= eventDateTimeTill)
            {
                MessageBox.Show("Дата та час кінця події повинні бути пізніше за дату та час початку.", 
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Додати нову подію до списку events
            Event newEvent = new Event(false, eventName, eventDateTime, eventDateTimeTill, eventPlace);

            if (CheckEventOverlapAdd(newEvent))
            {
                MessageBox.Show("Подія накладається з іншою подією. Будь ласка, перенесіть подію.", 
                    "Накладання подій", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EventList.Add(newEvent);

                // Очистити поля вводу
                textName.Text = string.Empty;
                DateTimePicker.Value = DateTime.Now;
                DateTimePickerTill.Value = DateTime.Now;
                textPlace.Text = string.Empty;

                // Зберегти зміни у JSON файл
                SaveEventsToJson();
                LoadEventsFromJson();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю подію?", 
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Event selectedEvent = Table.SelectedRows[0].DataBoundItem as Event;
                    EventList.Remove(selectedEvent); // Видаляємо обрану подію зі списку
                    SaveEventsToJson(); // Зберігаємо події у JSON файл
                    LoadEventsFromJson();
                }
            }
        }

        private void Table_SelectionChanged(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                Event selectedEvent = Table.SelectedRows[0].DataBoundItem as Event;

                // Заповнення полів вводу даними з вибраної строки
                textName.Text = selectedEvent.Name;
                DateTimePicker.Value = selectedEvent.DateTime;
                DateTimePickerTill.Value = selectedEvent.DateTimeTill;
                textPlace.Text = selectedEvent.Place;
            }
            else
            {
                // Очистка полів вводу, якщо не вибрано жодної строки
                textName.Text = string.Empty;
                DateTimePicker.Value = DateTime.Now;
                DateTimePickerTill.Value = DateTime.Now;
                textPlace.Text = string.Empty;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (Table.SelectedRows.Count > 0)
            {
                string eventName = textName.Text.Trim();
                DateTime eventDateTime = DateTimePicker.Value;
                DateTime eventDateTimeTill = DateTimePickerTill.Value;
                string eventPlace = textPlace.Text.Trim();

                // Перевірити, чи всі поля заповнені
                if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(eventPlace))
                {
                    MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Перевірити коректність дат та часу
                if (eventDateTime >= eventDateTimeTill)
                {
                    MessageBox.Show("Дата та час кінця події повинні бути пізніше за дату та час початку.", 
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Event selectedEvent = Table.SelectedRows[0].DataBoundItem as Event;

                selectedEvent.Name = eventName;
                selectedEvent.DateTime = eventDateTime;
                selectedEvent.DateTimeTill = eventDateTimeTill;
                selectedEvent.Place = eventPlace;

                if (CheckEventOverlapChange(selectedEvent))
                {
                    MessageBox.Show("Подія накладається з іншою подією. Будь ласка, перенесіть подію.", 
                        "Накладання подій", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Ви впевнені, що хочете змінити цю подію?",
                    "Підтвердження змін", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Table.Refresh();

                        // Очистити поля вводу
                        textName.Text = string.Empty;
                        DateTimePicker.Value = DateTime.Now;
                        DateTimePickerTill.Value = DateTime.Now;
                        textPlace.Text = string.Empty;

                        SaveEventsToJson();
                    }
                }
            }
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            selectedDate = DatePicker.Value.Date;
            var filteredEvents = EventList.Where(ev => ev.DateTime.Date == selectedDate).ToList();
            filteredEvents.Sort((ev1, ev2) => ev1.DateTime.CompareTo(ev2.DateTime));
            BindingList<Event> sortedEvents = new BindingList<Event>(filteredEvents);
            Table.DataSource = sortedEvents;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            selectedDate = DateTime.MinValue;
            LoadEventsFromJson();
        }

        private void YesterdayEventsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            YesterdayEventsForm yesterdayeventsform = new YesterdayEventsForm();
            yesterdayeventsform.Show();
        }
    }
}