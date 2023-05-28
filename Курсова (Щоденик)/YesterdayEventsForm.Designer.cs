namespace Курсова__Щоденик_
{
    partial class YesterdayEventsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.WatchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.Location = new System.Drawing.Point(487, 89);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(235, 27);
            this.DatePicker.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(235, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Оберіть нову дату та час:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(294, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 48);
            this.label1.TabIndex = 41;
            this.label1.Text = "Вчорашні справи";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.Location = new System.Drawing.Point(933, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 36);
            this.CloseButton.TabIndex = 40;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click_1);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.Silver;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Table.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Table.Location = new System.Drawing.Point(0, 273);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Table.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.RowTemplate.Height = 29;
            this.Table.Size = new System.Drawing.Size(985, 326);
            this.Table.TabIndex = 39;
            // 
            // WatchButton
            // 
            this.WatchButton.BackColor = System.Drawing.Color.White;
            this.WatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WatchButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WatchButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WatchButton.Location = new System.Drawing.Point(247, 195);
            this.WatchButton.Name = "WatchButton";
            this.WatchButton.Size = new System.Drawing.Size(185, 51);
            this.WatchButton.TabIndex = 38;
            this.WatchButton.Text = "Перенести";
            this.WatchButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(537, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 51);
            this.button1.TabIndex = 44;
            this.button1.Text = "Видалити";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 27);
            this.dateTimePicker1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Оберіть тривалість (до):";
            // 
            // YesterdayEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 599);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.WatchButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YesterdayEventsForm";
            this.Text = "YesterdayEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DatePicker;
        private Label label3;
        private Label label1;
        private Button CloseButton;
        private DataGridView Table;
        private Button WatchButton;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}