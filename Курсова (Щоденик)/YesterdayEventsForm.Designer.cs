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
            this.newDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.YesterdayTable = new System.Windows.Forms.DataGridView();
            this.YesterdayWatchButton = new System.Windows.Forms.Button();
            this.YesterdayDeleteButton = new System.Windows.Forms.Button();
            this.newDateTimeTillPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YesterdayTable)).BeginInit();
            this.SuspendLayout();
            // 
            // newDateTimePicker
            // 
            this.newDateTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newDateTimePicker.Location = new System.Drawing.Point(281, 123);
            this.newDateTimePicker.Name = "newDateTimePicker";
            this.newDateTimePicker.Size = new System.Drawing.Size(235, 27);
            this.newDateTimePicker.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 126);
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
            this.label1.Location = new System.Drawing.Point(335, 12);
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
            this.CloseButton.Location = new System.Drawing.Point(933, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 36);
            this.CloseButton.TabIndex = 40;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // YesterdayTable
            // 
            this.YesterdayTable.AllowUserToAddRows = false;
            this.YesterdayTable.AllowUserToDeleteRows = false;
            this.YesterdayTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YesterdayTable.BackgroundColor = System.Drawing.Color.Silver;
            this.YesterdayTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YesterdayTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.YesterdayTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YesterdayTable.Location = new System.Drawing.Point(0, 310);
            this.YesterdayTable.Name = "YesterdayTable";
            this.YesterdayTable.ReadOnly = true;
            this.YesterdayTable.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YesterdayTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.YesterdayTable.RowTemplate.Height = 29;
            this.YesterdayTable.Size = new System.Drawing.Size(985, 289);
            this.YesterdayTable.TabIndex = 39;
            // 
            // YesterdayWatchButton
            // 
            this.YesterdayWatchButton.BackColor = System.Drawing.Color.White;
            this.YesterdayWatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesterdayWatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesterdayWatchButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YesterdayWatchButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.YesterdayWatchButton.Location = new System.Drawing.Point(335, 230);
            this.YesterdayWatchButton.Name = "YesterdayWatchButton";
            this.YesterdayWatchButton.Size = new System.Drawing.Size(185, 51);
            this.YesterdayWatchButton.TabIndex = 38;
            this.YesterdayWatchButton.Text = "Перенести";
            this.YesterdayWatchButton.UseVisualStyleBackColor = false;
            // 
            // YesterdayDeleteButton
            // 
            this.YesterdayDeleteButton.BackColor = System.Drawing.Color.White;
            this.YesterdayDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesterdayDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesterdayDeleteButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YesterdayDeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.YesterdayDeleteButton.Location = new System.Drawing.Point(558, 230);
            this.YesterdayDeleteButton.Name = "YesterdayDeleteButton";
            this.YesterdayDeleteButton.Size = new System.Drawing.Size(185, 51);
            this.YesterdayDeleteButton.TabIndex = 44;
            this.YesterdayDeleteButton.Text = "Видалити";
            this.YesterdayDeleteButton.UseVisualStyleBackColor = false;
            // 
            // newDateTimeTillPicker
            // 
            this.newDateTimeTillPicker.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newDateTimeTillPicker.Location = new System.Drawing.Point(281, 170);
            this.newDateTimeTillPicker.Name = "newDateTimeTillPicker";
            this.newDateTimeTillPicker.Size = new System.Drawing.Size(235, 27);
            this.newDateTimeTillPicker.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Оберіть тривалість (до):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Для перенесення події на майбутьнє:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 36);
            this.BackButton.TabIndex = 48;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // YesterdayEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 599);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newDateTimeTillPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YesterdayDeleteButton);
            this.Controls.Add(this.newDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.YesterdayTable);
            this.Controls.Add(this.YesterdayWatchButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YesterdayEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YesterdayEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.YesterdayTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker newDateTimePicker;
        private Label label3;
        private Label label1;
        private Button CloseButton;
        private DataGridView YesterdayTable;
        private Button YesterdayWatchButton;
        private Button YesterdayDeleteButton;
        private DateTimePicker newDateTimeTillPicker;
        private Label label2;
        private Label label4;
        private Button BackButton;
    }
}