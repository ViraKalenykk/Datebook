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
    public partial class YesterdayEventsForm : Form
    {
        private BindingList<Event> events;

        public YesterdayEventsForm()
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
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                events = JsonConvert.DeserializeObject<BindingList<Event>>(json);
            }
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
