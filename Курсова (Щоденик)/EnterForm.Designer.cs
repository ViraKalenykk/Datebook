namespace Курсова__Щоденик_
{
	partial class EnterForm
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
			this.CustomerName = new System.Windows.Forms.TextBox();
			this.CustomerPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.EnterButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.ToRegisterLink = new System.Windows.Forms.LinkLabel();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(506, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 48);
			this.label1.TabIndex = 21;
			this.label1.Text = "Вхід";
			// 
			// CustomerName
			// 
			this.CustomerName.BackColor = System.Drawing.Color.White;
			this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CustomerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CustomerName.Location = new System.Drawing.Point(524, 219);
			this.CustomerName.Multiline = true;
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(319, 49);
			this.CustomerName.TabIndex = 22;
			this.CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// CustomerPassword
			// 
			this.CustomerPassword.BackColor = System.Drawing.Color.White;
			this.CustomerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CustomerPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CustomerPassword.Location = new System.Drawing.Point(524, 305);
			this.CustomerPassword.Name = "CustomerPassword";
			this.CustomerPassword.PasswordChar = '·';
			this.CustomerPassword.Size = new System.Drawing.Size(319, 32);
			this.CustomerPassword.TabIndex = 23;
			this.CustomerPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CustomerPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(399, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 40);
			this.label2.TabIndex = 24;
			this.label2.Text = "Ім\'я:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(342, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 40);
			this.label3.TabIndex = 25;
			this.label3.Text = "Пароль:";
			// 
			// EnterButton
			// 
			this.EnterButton.BackColor = System.Drawing.Color.White;
			this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.EnterButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.EnterButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.EnterButton.Location = new System.Drawing.Point(470, 409);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.Size = new System.Drawing.Size(228, 51);
			this.EnterButton.TabIndex = 26;
			this.EnterButton.Text = "Увійти";
			this.EnterButton.UseVisualStyleBackColor = false;
			this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(376, 542);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 24);
			this.label4.TabIndex = 27;
			this.label4.Text = "Ще не зареєстровані?";
			// 
			// ToRegisterLink
			// 
			this.ToRegisterLink.AutoSize = true;
			this.ToRegisterLink.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ToRegisterLink.LinkColor = System.Drawing.Color.Black;
			this.ToRegisterLink.Location = new System.Drawing.Point(603, 542);
			this.ToRegisterLink.Name = "ToRegisterLink";
			this.ToRegisterLink.Size = new System.Drawing.Size(187, 24);
			this.ToRegisterLink.TabIndex = 28;
			this.ToRegisterLink.TabStop = true;
			this.ToRegisterLink.Text = "Зареєструватися";
			this.ToRegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToRegisterLink_LinkClicked);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.White;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.CloseButton.Location = new System.Drawing.Point(1117, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(40, 36);
			this.CloseButton.TabIndex = 29;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// EnterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1169, 701);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ToRegisterLink);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.EnterButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CustomerPassword);
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "EnterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EnterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox CustomerName;
		private TextBox CustomerPassword;
		private Label label2;
		private Label label3;
		private Button EnterButton;
		private Label label4;
		private LinkLabel ToRegisterLink;
		private Button CloseButton;
	}
}