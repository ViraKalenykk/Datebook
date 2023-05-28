namespace Курсова__Щоденик_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTill = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YesterdayEventsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата та час:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тривалість (до):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Місце проведення:";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(224, 105);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(319, 32);
            this.textName.TabIndex = 6;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPlace
            // 
            this.textPlace.BackColor = System.Drawing.Color.White;
            this.textPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPlace.Location = new System.Drawing.Point(224, 246);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(319, 32);
            this.textPlace.TabIndex = 10;
            this.textPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(650, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 51);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(875, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.White;
            this.btnWatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatch.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWatch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWatch.Location = new System.Drawing.Point(875, 177);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(185, 51);
            this.btnWatch.TabIndex = 14;
            this.btnWatch.Text = "Переглянути";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.White;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChange.Location = new System.Drawing.Point(650, 177);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(185, 51);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Змінити";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.BackgroundColor = System.Drawing.Color.Silver;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.Location = new System.Drawing.Point(0, 339);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(1092, 264);
            this.table.TabIndex = 15;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.Location = new System.Drawing.Point(224, 152);
            this.DateTimePicker.MinDate = new System.DateTime(2023, 5, 28, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(319, 33);
            this.DateTimePicker.TabIndex = 16;
            // 
            // DateTimePickerTill
            // 
            this.DateTimePickerTill.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerTill.Location = new System.Drawing.Point(224, 198);
            this.DateTimePickerTill.Name = "DateTimePickerTill";
            this.DateTimePickerTill.Size = new System.Drawing.Size(319, 33);
            this.DateTimePickerTill.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(1040, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 36);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(443, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Щоденник";
            // 
            // YesterdayEventsButton
            // 
            this.YesterdayEventsButton.BackColor = System.Drawing.Color.White;
            this.YesterdayEventsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesterdayEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesterdayEventsButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YesterdayEventsButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.YesterdayEventsButton.Location = new System.Drawing.Point(650, 254);
            this.YesterdayEventsButton.Name = "YesterdayEventsButton";
            this.YesterdayEventsButton.Size = new System.Drawing.Size(410, 51);
            this.YesterdayEventsButton.TabIndex = 21;
            this.YesterdayEventsButton.Text = "Прострочені справи";
            this.YesterdayEventsButton.UseVisualStyleBackColor = false;
            this.YesterdayEventsButton.Click += new System.EventHandler(this.YesterdayEventsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 603);
            this.Controls.Add(this.YesterdayEventsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DateTimePickerTill);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Щоденник";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textName;
        private TextBox textPlace;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnWatch;
        private Button btnChange;
        private DataGridView table;
        private DateTimePicker DateTimePicker;
        private DateTimePicker DateTimePickerTill;
        private Button btnClose;
        private Label label1;
        private Button YesterdayEventsButton;
    }
}