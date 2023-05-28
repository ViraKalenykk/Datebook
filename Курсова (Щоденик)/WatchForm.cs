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
        private BindingList<Event> events;

        public WatchForm()
        {
            InitializeComponent();
            LoadEventsFromJson();
            Table.DataSource = events;

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
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                events = JsonConvert.DeserializeObject<BindingList<Event>>(json);
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
            var filteredEvents = events.Where(ev => ev.datetime.Date == selectedDate).ToList();
            filteredEvents.Sort((ev1, ev2) => ev1.datetime.CompareTo(ev2.datetime));
            BindingList<Event> sortedEvents = new BindingList<Event>(filteredEvents);
            Table.DataSource = sortedEvents;
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Table.Columns["isDone"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)Table.Rows[e.RowIndex].Cells["isDone"];
                bool currentStatus = (bool)checkBoxCell.Value;
                checkBoxCell.Value = !currentStatus;

                Event selectedEvent = events[e.RowIndex];
                selectedEvent.isDone = !currentStatus;
            }
        }
    }
}
