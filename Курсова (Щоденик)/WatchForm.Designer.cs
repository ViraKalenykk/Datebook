namespace Курсова__Щоденик_
{
    partial class WatchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WatchButton = new System.Windows.Forms.Button();
            this.WatchTable = new System.Windows.Forms.DataGridView();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WatchTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 48);
            this.label1.TabIndex = 35;
            this.label1.Text = "Перегляд подій за обраною датою";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.Location = new System.Drawing.Point(1011, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 36);
            this.CloseButton.TabIndex = 34;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WatchButton
            // 
            this.WatchButton.BackColor = System.Drawing.Color.White;
            this.WatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WatchButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WatchButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.WatchButton.Location = new System.Drawing.Point(449, 172);
            this.WatchButton.Name = "WatchButton";
            this.WatchButton.Size = new System.Drawing.Size(185, 51);
            this.WatchButton.TabIndex = 30;
            this.WatchButton.Text = "Переглянути";
            this.WatchButton.UseVisualStyleBackColor = false;
            this.WatchButton.Click += new System.EventHandler(this.WatchButton_Click);
            // 
            // WatchTable
            // 
            this.WatchTable.AllowUserToAddRows = false;
            this.WatchTable.AllowUserToDeleteRows = false;
            this.WatchTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WatchTable.BackgroundColor = System.Drawing.Color.Silver;
            this.WatchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WatchTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WatchTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WatchTable.Location = new System.Drawing.Point(0, 264);
            this.WatchTable.Name = "WatchTable";
            this.WatchTable.ReadOnly = true;
            this.WatchTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WatchTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.WatchTable.RowTemplate.Height = 29;
            this.WatchTable.Size = new System.Drawing.Size(1064, 326);
            this.WatchTable.TabIndex = 31;
            this.WatchTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.Location = new System.Drawing.Point(502, 110);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(235, 27);
            this.DatePicker.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(355, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Оберіть дату:";
            // 
            // WatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 590);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.WatchTable);
            this.Controls.Add(this.WatchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.WatchTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button CloseButton;
        private Button WatchButton;
        private DataGridView WatchTable;
        private DateTimePicker DatePicker;
        private Label label3;
    }
}