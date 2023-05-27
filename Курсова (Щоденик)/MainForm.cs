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
        private BindingList<Event> events = new BindingList<Event>();

        public MainForm()
        {
            InitializeComponent();
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimePicker.ShowUpDown = true;
            DateTimePickerTill.Format = DateTimePickerFormat.Custom;
            DateTimePickerTill.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimePickerTill.ShowUpDown = true;

            LoadEventsFromJson();
            table.DataSource = events;

            table.Columns["isDone"].HeaderText = "Стан";
            table.Columns["name"].HeaderText = "Назва";
            table.Columns["datetime"].HeaderText = "Дата та час";
            table.Columns["datetimetill"].HeaderText = "Тривалість (до)";
            table.Columns["place"].HeaderText = "Місце проведення";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "isDone";
            checkBoxColumn.HeaderText = "Стан";
            checkBoxColumn.Name = "isDone";
            checkBoxColumn.ReadOnly = false;
            table.Columns.Remove("isDone");
            table.Columns.Insert(0, checkBoxColumn);
            table.CellContentClick += Table_CellContentClick;

        }

        private void SaveEventsToJson()
        {
            string json = JsonConvert.SerializeObject(events);
            File.WriteAllText("events.json", json);
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                events = JsonConvert.DeserializeObject<BindingList<Event>>(json);
            }
        }

        private bool CheckEventOverlapChange(Event newEvent)
        {
            foreach (Event existingEvent in events)
            {
                if (existingEvent == table.SelectedRows[0].DataBoundItem)
                    continue;

                if (newEvent.datetime < existingEvent.datetimetill && newEvent.datetimetill > existingEvent.datetime)
                {
                    return true; // Є накладання подій
                }
            }
            return false; // Немає накладання подій
        }

        private bool CheckEventOverlapAdd(Event newEvent)
        {
            foreach (Event existingEvent in events)
            {
                if (newEvent.datetime < existingEvent.datetimetill && newEvent.datetimetill > existingEvent.datetime)
                {
                    return true; // Є накладання подій
                }
            }
            return false; // Немає накладання подій
        }


        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == table.Columns["isDone"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)table.Rows[e.RowIndex].Cells["isDone"];
                bool currentStatus = (bool)checkBoxCell.Value;
                checkBoxCell.Value = !currentStatus;

                // Оновити відповідну подію у списку events
                Event selectedEvent = events[e.RowIndex];
                selectedEvent.isDone = !currentStatus;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
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
                events.Add(newEvent);

                // Очистити поля вводу
                textName.Text = string.Empty;
                DateTimePicker.Value = DateTime.Now;
                DateTimePickerTill.Value = DateTime.Now;
                textPlace.Text = string.Empty;

                // Зберегти зміни у JSON файл
                SaveEventsToJson();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю подію?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Event selectedEvent = table.SelectedRows[0].DataBoundItem as Event;
                    events.Remove(selectedEvent); // Видаляємо обрану подію зі списку
                    SaveEventsToJson(); // Зберігаємо події у JSON файл
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
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

                Event selectedEvent = table.SelectedRows[0].DataBoundItem as Event;

                selectedEvent.name = eventName;
                selectedEvent.datetime = eventDateTime;
                selectedEvent.datetimetill = eventDateTimeTill;
                selectedEvent.place = eventPlace;

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
                        table.Refresh();

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
    }
}