﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using Курсова__Щоденик_.Model;

namespace Курсова__Щоденик_
{
	public partial class EnterForm : Form
	{
		private bool IsDragging = false;
		private Point DragStartPosition;
		private List<Customer> CustomerList = new List<Customer>();

		public EnterForm()
		{
			InitializeComponent();
			this.MouseDown += EnterForm_MouseDown;
			this.MouseMove += EnterForm_MouseMove;
			this.MouseUp += EnterForm_MouseUp;

			LoadCustomersData();

			this.CustomerPassword.AutoSize = false;
			this.CustomerPassword.Size = new Size(this.CustomerPassword.Width, 49);
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void EnterForm_MouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				IsDragging = true;
				DragStartPosition = e.Location;
			}
		}

		private void EnterForm_MouseMove(object? sender, MouseEventArgs e)
		{
			if (IsDragging)
			{
				Point diff = Point.Subtract(e.Location, new Size(DragStartPosition));
				this.Location = Point.Add(this.Location, new Size(diff));
			}
		}

		private void EnterForm_MouseUp(object? sender, MouseEventArgs e)
		{
			IsDragging = false;
		}

		private void EnterButton_Click(object sender, EventArgs e)
		{
			string customerName = CustomerName.Text;
			string customerPassword = CustomerPassword.Text;

			if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerPassword))
			{
				MessageBox.Show("Введіть ім'я та пароль користувача.", "Помилка");
				return;
			}

			Customer customer = CustomerList.FirstOrDefault(c => c.Name == customerName && c.Password == customerPassword);

			if (customer != null)
			{
				MainForm mainForm = new MainForm(new List<Customer> { customer });
				mainForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Невірні дані користувача.", "Помилка");
			}
		}

		public void LoadCustomersData()
		{
			string jsonFilePath = "C:/Users/Asus/Downloads/Курсова/Курсова (Щоденик)/Курсова (Щоденик)/Documents/customer.json";

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


		private void ToRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegisterForm registerForm = new RegisterForm();
			registerForm.Show();
			this.Hide();
		}


	}
}
