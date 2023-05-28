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
            YesterdayTable.DataSource = events;

            YesterdayTable.Columns["isDone"].HeaderText = "Стан";
            YesterdayTable.Columns["name"].HeaderText = "Назва";
            YesterdayTable.Columns["datetime"].HeaderText = "Дата та час";
            YesterdayTable.Columns["datetimetill"].HeaderText = "Тривалість (до)";
            YesterdayTable.Columns["place"].HeaderText = "Місце проведення";

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.DataPropertyName = "isDone";
            checkBoxColumn.HeaderText = "Стан";
            checkBoxColumn.Name = "isDone";
            checkBoxColumn.ReadOnly = false;
            YesterdayTable.Columns.Remove("isDone");
            YesterdayTable.Columns.Insert(0, checkBoxColumn);

            NewDateTimePicker.Format = DateTimePickerFormat.Custom;
            NewDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            NewDateTimePicker.ShowUpDown = true;
            NewDateTimeTillPicker.Format = DateTimePickerFormat.Custom;
            NewDateTimeTillPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            NewDateTimeTillPicker.ShowUpDown = true;
        }

        private void LoadEventsFromJson()
        {
            if (File.Exists("events.json"))
            {
                string json = File.ReadAllText("events.json");
                events = JsonConvert.DeserializeObject<BindingList<Event>>(json);

                events = new BindingList<Event>(events.Where(e => e.datetimetill < DateTime.Now).ToList());
            }
        }

        private void SaveEventsToJson()
        {
            string json = JsonConvert.SerializeObject(events);
            File.WriteAllText("events.json", json);
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void YesterdayDeleteButton_Click(object sender, EventArgs e)
        {
            if (YesterdayTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю подію?", 
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Event selectedEvent = YesterdayTable.SelectedRows[0].DataBoundItem as Event;
                    events.Remove(selectedEvent); // Видаляємо обрану подію зі списку
                    SaveEventsToJson(); // Зберігаємо події у JSON файл
                }
            }
        }


    }
}
