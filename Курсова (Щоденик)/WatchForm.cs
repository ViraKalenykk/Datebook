using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсова__Щоденик_.Model;

namespace Курсова__Щоденик_
{
    public partial class WatchForm : Form
    {
        private BindingList<Event> EventList;

        public WatchForm()
        {
            InitializeComponent();
            LoadEventsFromJson();
            WatchTable.DataSource = EventList;

            WatchTable.Columns["isDone"].HeaderText = "Стан";
            WatchTable.Columns["name"].HeaderText = "Назва";
            WatchTable.Columns["datetime"].HeaderText = "Дата та час";
            WatchTable.Columns["datetimetill"].HeaderText = "Тривалість (до)";
            WatchTable.Columns["place"].HeaderText = "Місце проведення";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "isDone";
            checkBoxColumn.HeaderText = "Стан";
            checkBoxColumn.Name = "isDone";
            checkBoxColumn.ReadOnly = false;
            WatchTable.Columns.Remove("isDone");
            WatchTable.Columns.Insert(0, checkBoxColumn);
            WatchTable.CellContentClick += Table_CellContentClick;
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                EventList = JsonConvert.DeserializeObject<BindingList<Event>>(json);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void WatchButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = DatePicker.Value.Date;
            var filteredEvents = EventList.Where(ev => ev.DateTime.Date == selectedDate).ToList();
            filteredEvents.Sort((ev1, ev2) => ev1.DateTime.CompareTo(ev2.DateTime));
            BindingList<Event> sortedEvents = new BindingList<Event>(filteredEvents);
            WatchTable.DataSource = sortedEvents;
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == WatchTable.Columns["isDone"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)WatchTable.Rows[e.RowIndex].Cells["isDone"];
                bool currentStatus = (bool)checkBoxCell.Value;
                checkBoxCell.Value = !currentStatus;

                Event selectedEvent = EventList[e.RowIndex];
                selectedEvent.IsDone = !currentStatus;
            }
        }
    }
}
