namespace Курсова__Щоденик_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimePicker.ShowUpDown = true;
            DateTimePickerTill.Format = DateTimePickerFormat.Custom;
            DateTimePickerTill.CustomFormat = "dd/MM/yyyy HH:mm";
            DateTimePickerTill.ShowUpDown = true;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = DateTimePicker.Value;
        }

        private void TimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = DateTimePickerTill.Value;
        }

        private void textPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(0, textName.Text, DateTimePicker.Value, DateTimePickerTill.Value, textPlace.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (table.CurrentRow.Cells != null)
            {
                table.Rows.RemoveAt(table.CurrentRow.Index);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (table.CurrentRow.Cells != null)
            {
                table.CurrentRow.Cells["name"].Value = textName.Text;
                table.CurrentRow.Cells["datetime"].Value = DateTimePicker.Value;
                table.CurrentRow.Cells["datetimetill"].Value = DateTimePickerTill.Value;
                table.CurrentRow.Cells["place"].Value = textPlace.Text;
            }
        }

        private void btnLookover_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}