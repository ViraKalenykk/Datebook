namespace Курсова__Щоденик_
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.NewCustomerPassword = new System.Windows.Forms.TextBox();
			this.NewCustomerName = new System.Windows.Forms.TextBox();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(482, 118);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 45);
			this.label1.TabIndex = 21;
			this.label1.Text = "Реєстрація";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(321, 311);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 40);
			this.label3.TabIndex = 29;
			this.label3.Text = "Пароль:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(378, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 40);
			this.label2.TabIndex = 28;
			this.label2.Text = "Ім\'я:";
			// 
			// NewCustomerPassword
			// 
			this.NewCustomerPassword.BackColor = System.Drawing.Color.White;
			this.NewCustomerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewCustomerPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewCustomerPassword.Location = new System.Drawing.Point(527, 306);
			this.NewCustomerPassword.Multiline = true;
			this.NewCustomerPassword.Name = "NewCustomerPassword";
			this.NewCustomerPassword.Size = new System.Drawing.Size(319, 51);
			this.NewCustomerPassword.TabIndex = 27;
			this.NewCustomerPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NewCustomerName
			// 
			this.NewCustomerName.BackColor = System.Drawing.Color.White;
			this.NewCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NewCustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewCustomerName.Location = new System.Drawing.Point(527, 214);
			this.NewCustomerName.Multiline = true;
			this.NewCustomerName.Name = "NewCustomerName";
			this.NewCustomerName.Size = new System.Drawing.Size(319, 51);
			this.NewCustomerName.TabIndex = 26;
			this.NewCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RegisterButton
			// 
			this.RegisterButton.BackColor = System.Drawing.Color.White;
			this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RegisterButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.RegisterButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.RegisterButton.Location = new System.Drawing.Point(482, 416);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(228, 51);
			this.RegisterButton.TabIndex = 30;
			this.RegisterButton.Text = "Зарєеструватися";
			this.RegisterButton.UseVisualStyleBackColor = false;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.White;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.CloseButton.Location = new System.Drawing.Point(1118, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(40, 36);
			this.CloseButton.TabIndex = 31;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1170, 700);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NewCustomerPassword);
			this.Controls.Add(this.NewCustomerName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label3;
		private Label label2;
		private TextBox NewCustomerPassword;
		private TextBox NewCustomerName;
		private Button RegisterButton;
		private Button CloseButton;
	}
}