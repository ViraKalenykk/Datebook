namespace Курсова__Щоденик_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textName.Text, DatePicker.Value, TimePickerFrom.Value, textPlace.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void btnLookover_Click(object sender, EventArgs e)
        {

        }
    }
}