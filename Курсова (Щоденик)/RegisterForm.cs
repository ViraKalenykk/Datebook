using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using Курсова__Щоденик_.Model;

namespace Курсова__Щоденик_
{
	public partial class RegisterForm : Form
	{
		private bool IsDragging = false;
		private Point DragStartPosition;
		private List<Customer>? CustomerList = new List<Customer>();

		public RegisterForm()
		{
			InitializeComponent();
			this.MouseDown += RegisterForm_MouseDown;
			this.MouseMove += RegisterForm_MouseMove;
			this.MouseUp += RegisterForm_MouseUp;
		}

		private void RegisterForm_MouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				IsDragging = true;
				DragStartPosition = e.Location;
			}
		}

		private void RegisterForm_MouseMove(object? sender, MouseEventArgs e)
		{
			if (IsDragging)
			{
				Point diff = Point.Subtract(e.Location, new Size(DragStartPosition));
				this.Location = Point.Add(this.Location, new Size(diff));
			}
		}

		private void RegisterForm_MouseUp(object? sender, MouseEventArgs e)
		{
			IsDragging = false;
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			string newCustomerName = NewCustomerName.Text;
			string newCustomerPassword = NewCustomerPassword.Text;

			if (string.IsNullOrWhiteSpace(newCustomerName) || string.IsNullOrWhiteSpace(newCustomerPassword))
			{
				MessageBox.Show("Будь ласка, заповніть всі поля.");
				return;
			}

			if (newCustomerName.Length < 2 || newCustomerName.Length > 100)
			{
				MessageBox.Show("Ім'я користувача повинно містити від 2 до 100 символів.", "Помилка");
				return;
			}

			if (!System.Text.RegularExpressions.Regex.IsMatch(newCustomerPassword, @"^\d{6}$"))
			{
				MessageBox.Show("Пароль користувача повинен містити рівно 6 цифр.", "Помилка");
				return;
			}

			if (CustomerList is null)
			{
				CustomerList = new List<Customer>();
			}

			if (CustomerList.Any(c => c.Name == newCustomerName))
			{
				MessageBox.Show("Користувач з таким іменем вже існує.");
				return;
			}

			Customer newCustomer = new Customer
			{
				Name = newCustomerName,
				Password = newCustomerPassword,
				Events = new BindingList<Event>()
			};

			LoadCustomersData();

			CustomerList.Add(newCustomer);
			SaveCustomersData();

			NewCustomerName.Text = string.Empty;
			NewCustomerPassword.Text = string.Empty;

			MessageBox.Show("Реєстрація успішна!");

			EnterForm? enterForm = Application.OpenForms.OfType<EnterForm>().FirstOrDefault();
			if (enterForm != null)
			{
				enterForm.LoadCustomersData();
				enterForm.Show();
			}

			this.Close();
		}

		public void LoadCustomersData()
		{
			string jsonFilePath = "Documents/customer.json";

			if (File.Exists(jsonFilePath))
			{
				string jsonData = File.ReadAllText(jsonFilePath);
				CustomerList = JsonConvert.DeserializeObject<List<Customer>>(jsonData);
			}
			else
			{
				CustomerList = new List<Customer>();
			}
		}

		private void SaveCustomersData()
		{
			string jsonFilePath = "Documents/customer.json";
			string jsonData = JsonConvert.SerializeObject(CustomerList);
			File.WriteAllText(jsonFilePath, jsonData);
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
