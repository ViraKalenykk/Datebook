using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using Курсова__Щоденик_.Model;

namespace Курсова__Щоденик_
{
	public partial class MainForm : Form
	{
		private bool IsDragging = false;
		private Point DragStartPosition;
		private DateTime selectedDate;
		private List<Customer> customers;
		private Customer currentCustomer;
		private BindingList<Event> EventList = new BindingList<Event>();

		private const string jsonFilePath = "C:/Users/Asus/Downloads/Курсова/Курсова (Щоденик)/Курсова (Щоденик)/Documents/customer.json";
		private const string DateTimeFormat = "dd/MM/yyyy HH:mm";
		private const string DateFormat = "dd/MM/yyyy";
		private const string TimeFormat = "HH:mm";
		private const string EventState = "Стан";
		private const string EventName = "Назва";
		private const string EventDateTime = "Дата та час";
		private const string EventDateTimeTill = "Тривалість (до)";
		private const string EventPlace = "Місце проведення";

		public MainForm(List<Customer> customers)
		{
			InitializeComponent();

			this.Shown += MainForm_Shown;
			this.customers = customers;

			DateTimePicker.Format = DateTimePickerFormat.Custom;
			DateTimePicker.CustomFormat = DateTimeFormat;
			DateTimePicker.ShowUpDown = true;
			DateTimePickerTill.Format = DateTimePickerFormat.Custom;
			DateTimePickerTill.CustomFormat = DateTimeFormat;
			DateTimePickerTill.ShowUpDown = true;
			DateForMovePicker.Format = DateTimePickerFormat.Custom;
			DateForMovePicker.CustomFormat = DateFormat;
			DateForMovePicker.ShowUpDown = true;
			TimePicker.Format = DateTimePickerFormat.Custom;
			TimePicker.CustomFormat = TimeFormat;
			TimePicker.ShowUpDown = true;

			LoadEventsFromJson();

			foreach (Customer customer in customers)
			{
				Table.DataSource = EventList;

				this.MouseDown += MainForm_MouseDown;
				this.MouseMove += MainForm_MouseMove;
				this.MouseUp += MainForm_MouseUp;

				currentCustomer = customer;
				SetupTableStyle();
			}
		}

		private void SetupTableStyle()
		{
			Table.Columns["isDone"].HeaderText = EventState;
			Table.Columns["name"].HeaderText = EventName;
			Table.Columns["datetime"].HeaderText = EventDateTime;
			Table.Columns["datetimetill"].HeaderText = EventDateTimeTill;
			Table.Columns["place"].HeaderText = EventPlace;
			Table.Columns["isExpired"].Visible = false;

			DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
			checkBoxColumn.DataPropertyName = "isDone";
			checkBoxColumn.HeaderText = EventState;
			checkBoxColumn.Name = "isDone";
			checkBoxColumn.ReadOnly = false;
			Table.CellContentClick += Table_CellContentClick;

			Table.SelectionChanged += Table_SelectionChanged;
			Table.CellFormatting += Table_CellFormatting;
		}

		private DateTime roundToMinute(DateTime dateTime)
		{
			return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_MouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				IsDragging = true;
				DragStartPosition = e.Location;
			}
		}

		private void MainForm_MouseMove(object? sender, MouseEventArgs e)
		{
			if (IsDragging)
			{
				Point diff = Point.Subtract(e.Location, new Size(DragStartPosition));
				this.Location = Point.Add(this.Location, new Size(diff));
			}
		}

		private void MainForm_MouseUp(object? sender, MouseEventArgs e)
		{
			IsDragging = false;
		}

		private void SaveEventsToJson()
		{
			List<Customer> customerList;

			if (File.Exists(jsonFilePath))
			{
				string json = File.ReadAllText(jsonFilePath);
				customerList = JsonConvert.DeserializeObject<List<Customer>>(json);

				Customer existingCustomer = customerList.FirstOrDefault(c => c.Name == currentCustomer.Name);
				if (existingCustomer != null)
				{
					existingCustomer.Events = currentCustomer.Events;
				}
				else
				{
					customerList.Add(currentCustomer);
				}
			}
			else
			{
				customerList = new List<Customer>
		{
			currentCustomer
		};
			}

			string jsonData = JsonConvert.SerializeObject(customerList);
			File.WriteAllText(jsonFilePath, jsonData);
		}

		private void LoadEventsFromJson()
		{
			string json = File.ReadAllText(jsonFilePath);
			List<Customer> customerList = JsonConvert.DeserializeObject<List<Customer>>(json);
			Customer customer = customerList.FirstOrDefault();
			if (customer != null)
			{
				EventList = new BindingList<Event>(customer.Events.OrderBy(e => e.DateTime).ToList());
				Table.DataSource = EventList;
			}
			Table.Columns["isDone"].DataPropertyName = "isDone";
		}

		private Event? GetNextEvent()
		{
			Event? nextEvent = null;
			DateTime currentTime = DateTime.Now;

			foreach (Event ev in EventList)
			{
				if (ev.DateTime >= currentTime && (nextEvent == null || 
					ev.DateTime < nextEvent.DateTime))
				{
					nextEvent = ev;
				}
			}
			return nextEvent;
		}

		private void ShowNextEventReminder()
		{
			Event? nextEvent = GetNextEvent();

			if (nextEvent != null)
			{
				TimeSpan timeRemaining = nextEvent.DateTime - DateTime.Now;

				timeRemaining = new TimeSpan((long)Math.Round((double)timeRemaining.Ticks, 
					MidpointRounding.AwayFromZero));

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

				MessageBox.Show($"Найближча подія: {nextEvent.Name}\nДата та час: " +
					$"{nextEvent.DateTime.ToString("dd.MM.yyyy HH:mm")}\nЗалишилося часу:" 
					+ $" {formattedTimeRemaining}", "Нагадування");
			}
			else
			{
				MessageBox.Show("Немає жодної справи. Додайте першу справу)", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void MainForm_Shown(object? sender, EventArgs e)
		{
			ShowNextEventReminder();
		}

		private bool CheckEventOverlapChange(Event changedEvent)
		{
			foreach (Event existingEvent in currentCustomer.Events)
			{
				if (existingEvent.Equals(changedEvent))
					continue;

				if (changedEvent.DateTime < existingEvent.DateTimeTill
					&& changedEvent.DateTimeTill > existingEvent.DateTime
					&& (changedEvent.DateTime != existingEvent.DateTimeTill
					&& changedEvent.DateTimeTill != existingEvent.DateTime))
				{
					return true;
				}
			}

			return false;
		}

		private bool CheckEventOverlapAdd(Event newEvent)
		{
			foreach (Event existingEvent in currentCustomer.Events)
			{
				if ((newEvent.DateTime >= existingEvent.DateTime
					&& newEvent.DateTime < existingEvent.DateTimeTill)
					|| (newEvent.DateTimeTill > existingEvent.DateTime
					&& newEvent.DateTimeTill <= existingEvent.DateTimeTill)
					|| (newEvent.DateTime <= existingEvent.DateTime
					&& newEvent.DateTimeTill >= existingEvent.DateTimeTill))
				{
					return true;
				}
			}

			return false;
		}

		private void Table_CellContentClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 0)
			{
				DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)Table.Rows[e.RowIndex].Cells["isDone"];
				Event selectedEvent = (Event)Table.Rows[e.RowIndex].DataBoundItem;
				checkBoxCell.Value = !(bool)checkBoxCell.Value;
				selectedEvent.IsDone = (bool)checkBoxCell.Value;
				SaveEventsToJson();
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			string eventName = textName.Text.Trim();
			DateTime eventDateTime = DateTimePicker.Value;
			DateTime eventDateTimeTill = DateTimePickerTill.Value;
			string eventPlace = textPlace.Text.Trim();
			eventDateTime = roundToMinute(eventDateTime);
			eventDateTimeTill = roundToMinute(eventDateTimeTill);

			if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(eventPlace))
			{
				MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (eventDateTime >= eventDateTimeTill)
			{
				MessageBox.Show("Дата та час кінця справи повинні бути пізніше за дату та час " +
					"початку.","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Event newEvent = 
				new Event(false, eventName, eventDateTime, eventDateTimeTill, eventPlace);

			foreach (Event existingEvent in currentCustomer.Events)
			{
				if (existingEvent.Name == eventName 
					&& existingEvent.Place == eventPlace 
					&& existingEvent.DateTime != eventDateTime)
				{
					string message = string.Format("Справа '{0}' та місцем проведення '{1}'  " +
						"уже існує на " + $"{existingEvent.DateTime.ToString("dd.MM.yyyy HH:mm")}. " +
						"Ви впевнені, що хочете додати нову справу?", eventName, eventPlace, 
						existingEvent.DateTime);

					DialogResult result = MessageBox.Show(message, "Попередження", 
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

					if (result == DialogResult.No)
					{
						return;
					}

					break;
				}
			}

			if (CheckEventOverlapAdd(newEvent))
			{
				MessageBox.Show("Справа накладається з іншою подією. Будь ласка, перенесіть " +
					"справу.", "Накладання подій", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				currentCustomer.Events.Add(newEvent);
				Table.Refresh();

				textName.Text = string.Empty;
				DateTimePicker.Value = DateTime.Now;
				DateTimePickerTill.Value = DateTime.Now;
				textPlace.Text = string.Empty;

				SaveEventsToJson();

				Table.DataSource = null;
				Table.DataSource = currentCustomer.Events;
				LoadEventsFromJson();
				SetupTableStyle();
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			if (Table.SelectedRows.Count > 0)
			{
				string message;
				if (Table.SelectedRows.Count == 1)
				{
					message = "Ви впевнені, що хочете видалити цю справу?";
				}
				else
				{
					message = "Ви впевнені, що хочете видалити ці справи?";
				}

				DialogResult result = MessageBox.Show(message, "Підтвердження видалення", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					List<Event> eventsToDelete = new List<Event>();

					foreach (DataGridViewRow row in Table.SelectedRows)
					{
						Event? selectedEvent = row.DataBoundItem as Event;
						if (selectedEvent != null)
						{
							eventsToDelete.Add(selectedEvent);
						}
					}

					foreach (Event selectedEvent in eventsToDelete)
					{
						currentCustomer.Events.Remove(selectedEvent);
					}

					SaveEventsToJson();

					Table.DataSource = null;
					Table.DataSource = currentCustomer.Events;
					LoadEventsFromJson();
					SetupTableStyle();

					string successMessage = (eventsToDelete.Count == 1) ? "Справу успішно видалено." : "Справи успішно видалено.";
					MessageBox.Show(successMessage, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Для видалення необхідно обрати справу, яку Ви хочете видалити.",
					"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}

		private void Table_SelectionChanged(object? sender, EventArgs e)
		{
			if (Table.SelectedRows.Count > 0)
			{
				Event? selectedEvent = Table.SelectedRows[0].DataBoundItem as Event;

				textName.Text = selectedEvent?.Name;
				DateTimePicker.Value = selectedEvent?.DateTime ?? DateTime.Now;
				DateTimePickerTill.Value = selectedEvent?.DateTimeTill ?? DateTime.Now;
				DateTimePicker.Value = roundToMinute(DateTimePicker.Value);
				DateTimePickerTill.Value = roundToMinute(DateTimePickerTill.Value);
				textPlace.Text = selectedEvent?.Place;
			}
			else
			{
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
				eventDateTime = roundToMinute(eventDateTime);
				eventDateTimeTill = roundToMinute(eventDateTimeTill);

				if (string.IsNullOrEmpty(eventName) || string.IsNullOrEmpty(eventPlace))
				{
					MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (eventDateTime >= eventDateTimeTill)
				{
					MessageBox.Show("Дата та час кінця події повинні бути пізніше за дату та час " +
						"початку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Event selectedEvent = currentCustomer.Events[Table.SelectedRows[0].Index];

				if (selectedEvent?.Name == eventName && 
					selectedEvent?.DateTime == eventDateTime &&
					selectedEvent?.DateTimeTill == eventDateTimeTill && 
					selectedEvent?.Place == eventPlace)
				{
					MessageBox.Show("Немає змін для цієї події.", "Інформація", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (selectedEvent != null)
				{
					selectedEvent.Name = eventName;
					selectedEvent.DateTime = eventDateTime;
					selectedEvent.DateTimeTill = eventDateTimeTill;
					selectedEvent.Place = eventPlace;

					if (CheckEventOverlapChange(selectedEvent))
					{
						MessageBox.Show("Подія накладається з іншою подією. " +
							"Будь ласка, перенесіть подію.", "Накладання подій", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						DialogResult result = MessageBox.Show("Ви впевнені, " +
							"що хочете змінити цю подію?", "Підтвердження змін", 
							MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (result == DialogResult.Yes)
						{
							textName.Text = string.Empty;
							DateTimePicker.Value = DateTime.Now;
							DateTimePickerTill.Value = DateTime.Now;
							textPlace.Text = string.Empty;

							SaveEventsToJson();

							Table.DataSource = null;
							Table.DataSource = currentCustomer.Events;
							SetupTableStyle();

							MessageBox.Show("Подію успішно змінено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadEventsFromJson();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("Для зміни необхідно обрати подію, яку Ви хочете змінити.",
					"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}

		private void WatchButton_Click(object sender, EventArgs e)
		{
			selectedDate = DatePicker.Value.Date;
			var filteredEvents = currentCustomer.Events
				.Where(ev => ev.DateTime.Date == selectedDate)
				.ToList();

			if (filteredEvents.Count == 0)
			{
				MessageBox.Show("Нажаль, за обраною датою подій немає.", "Повідомлення");
			}
			else
			{
				filteredEvents.Sort((ev1, ev2) => ev1.DateTime.CompareTo(ev2.DateTime));
				BindingList<Event> sortedEvents = new BindingList<Event>(filteredEvents);
				Table.DataSource = sortedEvents;
				Table.Refresh();
			}
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			selectedDate = DateTime.MinValue;
			LoadEventsFromJson();
		}

		private void Table_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < Table.Rows.Count)
			{
				DataGridViewRow row = Table.Rows[e.RowIndex];
				Event? currentEvent = row.DataBoundItem as Event;

				if (currentEvent != null && currentEvent.IsExpired)
				{
					row.DefaultCellStyle.BackColor = Color.LightPink;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.White;
				}
			}
		}

		private bool ConfirmEventMove()
		{
			DialogResult result = MessageBox.Show("Ви впевнені, що хочете перенести?",
				"Підтвердження перенесення події", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			return result == DialogResult.Yes;
		}

		private void MoveButton_Click(object sender, EventArgs e)
		{
			if (Table.SelectedRows.Count == 1)
			{
				DataGridViewRow selectedRow = Table.SelectedRows[0];
				Event selectedEvent = selectedRow.DataBoundItem as Event;

				if (selectedEvent != null)
				{
					DateTime newDate = DateForMovePicker.Value.Date;
					TimeSpan newTime = TimePicker.Value.TimeOfDay;

					DateTime newDateTime = newDate + newTime;
					TimeSpan duration = selectedEvent.DateTimeTill - selectedEvent.DateTime;
					newDateTime = roundToMinute(newDateTime);

					Event updatedEvent = new Event(false, selectedEvent.Name, newDateTime,
						newDateTime + duration, selectedEvent.Place);

					if (!CheckEventOverlapChange(updatedEvent))
					{
						if (ConfirmEventMove())
						{
							currentCustomer.Events.Remove(selectedEvent);
							currentCustomer.Events.Add(updatedEvent);
							Table.Refresh();
							SaveEventsToJson();
						}
						else
						{
							return;
						}
					}
					else
					{
						MessageBox.Show("Справа накладається з іншою справою. Будь ласка, " +
							"перенесіть справу на іншу дату або час.", "Накладання справ",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
			else if (Table.SelectedRows.Count > 1)
			{
				DateTime startDate = DateForMovePicker.Value.Date;
				TimeSpan startTime = TimePicker.Value.TimeOfDay;

				List<DataGridViewRow> rows =
					(from DataGridViewRow row in Table.SelectedRows
					 where !row.IsNewRow
					 orderby row.Index
					 select row).ToList<DataGridViewRow>();

				if (ConfirmEventMove())
				{
					foreach (DataGridViewRow row in rows)
					{
						Event selectedEvent = row.DataBoundItem as Event;

						if (selectedEvent != null && selectedEvent.Name != null
							&& selectedEvent.Place != null)
						{
							DateTime newDateTime = startDate + startTime;
							TimeSpan duration = selectedEvent.DateTimeTill - selectedEvent.DateTime;

							Event updatedEvent = new Event(false, selectedEvent.Name, newDateTime,
								newDateTime + duration, selectedEvent.Place);

							if (!CheckEventOverlapChange(updatedEvent))
							{
								currentCustomer.Events.Remove(selectedEvent);
								currentCustomer.Events.Add(updatedEvent);

								startDate = newDateTime.Date;
								startTime = newDateTime.TimeOfDay + duration +
									TimeSpan.FromMinutes((double)IntervalPicker.Value);
							}
							else
							{
								MessageBox.Show("Справи накладаються з іншими справами. " +
									"Будь ласка, перенесіть справи на іншу дату або час.",
									"Накладання справ", MessageBoxButtons.OK, MessageBoxIcon.Error);
								break;
							}
						}
					}
				Table.Refresh();
				SaveEventsToJson();
				}
			}
		LoadEventsFromJson();
		}
	}
}