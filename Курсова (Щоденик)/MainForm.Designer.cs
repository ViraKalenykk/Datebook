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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLookover = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerTill = new System.Windows.Forms.DateTimePicker();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimetill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 55);
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
            this.label3.Location = new System.Drawing.Point(73, 103);
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
            this.label4.Location = new System.Drawing.Point(38, 146);
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
            this.label6.Location = new System.Drawing.Point(15, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Місце проведення:";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Gainsboro;
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(217, 47);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(319, 32);
            this.textName.TabIndex = 6;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textPlace
            // 
            this.textPlace.BackColor = System.Drawing.Color.Gainsboro;
            this.textPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPlace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPlace.Location = new System.Drawing.Point(217, 188);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(319, 32);
            this.textPlace.TabIndex = 10;
            this.textPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPlace.TextChanged += new System.EventHandler(this.textPlace_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(645, 71);
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
            this.btnDelete.Location = new System.Drawing.Point(870, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 51);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLookover
            // 
            this.btnLookover.BackColor = System.Drawing.Color.White;
            this.btnLookover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLookover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLookover.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLookover.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLookover.Location = new System.Drawing.Point(870, 159);
            this.btnLookover.Name = "btnLookover";
            this.btnLookover.Size = new System.Drawing.Size(185, 51);
            this.btnLookover.TabIndex = 14;
            this.btnLookover.Text = "Переглянути";
            this.btnLookover.UseVisualStyleBackColor = false;
            this.btnLookover.Click += new System.EventHandler(this.btnLookover_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.White;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChange.Location = new System.Drawing.Point(645, 159);
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
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.done,
            this.name,
            this.datetime,
            this.datetimetill,
            this.place});
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.Location = new System.Drawing.Point(0, 328);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.table.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(1092, 293);
            this.table.TabIndex = 15;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePicker.Location = new System.Drawing.Point(217, 94);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(319, 33);
            this.DateTimePicker.TabIndex = 16;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DateTimePickerTill
            // 
            this.DateTimePickerTill.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerTill.Location = new System.Drawing.Point(217, 140);
            this.DateTimePickerTill.Name = "DateTimePickerTill";
            this.DateTimePickerTill.Size = new System.Drawing.Size(319, 33);
            this.DateTimePickerTill.TabIndex = 18;
            this.DateTimePickerTill.ValueChanged += new System.EventHandler(this.TimePicker1_ValueChanged);
            // 
            // done
            // 
            this.done.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.done.HeaderText = "Стан";
            this.done.MinimumWidth = 6;
            this.done.Name = "done";
            this.done.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Дата та час";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            // 
            // datetimetill
            // 
            this.datetimetill.HeaderText = "Тривалість (до)";
            this.datetimetill.MinimumWidth = 6;
            this.datetimetill.Name = "datetimetill";
            this.datetimetill.ReadOnly = true;
            // 
            // place
            // 
            this.place.HeaderText = "Місце проведення";
            this.place.MinimumWidth = 6;
            this.place.Name = "place";
            this.place.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 621);
            this.Controls.Add(this.DateTimePickerTill);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btnLookover);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Щоденник";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private Button btnLookover;
        private Button btnChange;
        private DataGridView table;
        private DateTimePicker DateTimePicker;
        private DateTimePicker DateTimePickerTill;
        private DataGridViewCheckBoxColumn done;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn datetime;
        private DataGridViewTextBoxColumn datetimetill;
        private DataGridViewTextBoxColumn place;
    }
}