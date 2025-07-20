namespace Schedule
{
    partial class TaskOverviewForm
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
            this.components = new System.ComponentModel.Container();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TaskTabPage = new System.Windows.Forms.TabPage();
            this.OptionalTaskCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionalLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.TaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CompletionComboBox = new System.Windows.Forms.ComboBox();
            this.ImportantTaskCheckBox = new System.Windows.Forms.CheckBox();
            this.ImportanceLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ReminderTabPage = new System.Windows.Forms.TabPage();
            this.OptionalReminderCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReminderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ImportantReminderCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReminderTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TaskTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumeric)).BeginInit();
            this.ReminderTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 369);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 30);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(661, 369);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 30);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TaskTabPage);
            this.TabControl.Controls.Add(this.ReminderTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(799, 351);
            this.TabControl.TabIndex = 8;
            // 
            // TaskTabPage
            // 
            this.TaskTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.TaskTabPage.Controls.Add(this.OptionalTaskCheckBox);
            this.TaskTabPage.Controls.Add(this.OptionalLabel);
            this.TaskTabPage.Controls.Add(this.DescriptionRichTextBox);
            this.TaskTabPage.Controls.Add(this.NameTextBox);
            this.TaskTabPage.Controls.Add(this.label2);
            this.TaskTabPage.Controls.Add(this.TimeNumeric);
            this.TaskTabPage.Controls.Add(this.TaskDateTimePicker);
            this.TaskTabPage.Controls.Add(this.CompletionComboBox);
            this.TaskTabPage.Controls.Add(this.ImportantTaskCheckBox);
            this.TaskTabPage.Controls.Add(this.ImportanceLabel);
            this.TaskTabPage.Controls.Add(this.TimeLabel);
            this.TaskTabPage.Controls.Add(this.StatusLabel);
            this.TaskTabPage.Controls.Add(this.label1);
            this.TaskTabPage.Controls.Add(this.DateLabel);
            this.TaskTabPage.Controls.Add(this.NameLabel);
            this.TaskTabPage.Location = new System.Drawing.Point(4, 22);
            this.TaskTabPage.Name = "TaskTabPage";
            this.TaskTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskTabPage.Size = new System.Drawing.Size(791, 325);
            this.TaskTabPage.TabIndex = 0;
            this.TaskTabPage.Text = "Task";
            // 
            // OptionalTaskCheckBox
            // 
            this.OptionalTaskCheckBox.AutoSize = true;
            this.OptionalTaskCheckBox.Location = new System.Drawing.Point(437, 277);
            this.OptionalTaskCheckBox.Name = "OptionalTaskCheckBox";
            this.OptionalTaskCheckBox.Size = new System.Drawing.Size(40, 17);
            this.OptionalTaskCheckBox.TabIndex = 31;
            this.OptionalTaskCheckBox.Text = "No";
            this.OptionalTaskCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionalLabel
            // 
            this.OptionalLabel.AutoSize = true;
            this.OptionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionalLabel.Location = new System.Drawing.Point(359, 274);
            this.OptionalLabel.Name = "OptionalLabel";
            this.OptionalLabel.Size = new System.Drawing.Size(72, 20);
            this.OptionalLabel.TabIndex = 30;
            this.OptionalLabel.Text = "Optional:";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(144, 73);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(636, 77);
            this.DescriptionRichTextBox.TabIndex = 29;
            this.DescriptionRichTextBox.Text = "";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 31);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(259, 20);
            this.NameTextBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(270, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Minutes";
            // 
            // TimeNumeric
            // 
            this.TimeNumeric.Location = new System.Drawing.Point(144, 241);
            this.TimeNumeric.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.TimeNumeric.Name = "TimeNumeric";
            this.TimeNumeric.Size = new System.Drawing.Size(120, 20);
            this.TimeNumeric.TabIndex = 26;
            // 
            // TaskDateTimePicker
            // 
            this.TaskDateTimePicker.Enabled = false;
            this.TaskDateTimePicker.Location = new System.Drawing.Point(143, 203);
            this.TaskDateTimePicker.Name = "TaskDateTimePicker";
            this.TaskDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.TaskDateTimePicker.TabIndex = 25;
            // 
            // CompletionComboBox
            // 
            this.CompletionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompletionComboBox.FormattingEnabled = true;
            this.CompletionComboBox.Items.AddRange(new object[] {
            "Incomplete",
            "1/4",
            "1/2",
            "3/4",
            "Complete"});
            this.CompletionComboBox.Location = new System.Drawing.Point(143, 166);
            this.CompletionComboBox.Name = "CompletionComboBox";
            this.CompletionComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompletionComboBox.TabIndex = 24;
            // 
            // ImportantTaskCheckBox
            // 
            this.ImportantTaskCheckBox.AutoSize = true;
            this.ImportantTaskCheckBox.Location = new System.Drawing.Point(143, 277);
            this.ImportantTaskCheckBox.Name = "ImportantTaskCheckBox";
            this.ImportantTaskCheckBox.Size = new System.Drawing.Size(90, 17);
            this.ImportantTaskCheckBox.TabIndex = 23;
            this.ImportantTaskCheckBox.Text = "Not Important";
            this.ImportantTaskCheckBox.UseVisualStyleBackColor = true;
            // 
            // ImportanceLabel
            // 
            this.ImportanceLabel.AutoSize = true;
            this.ImportanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportanceLabel.Location = new System.Drawing.Point(55, 274);
            this.ImportanceLabel.Name = "ImportanceLabel";
            this.ImportanceLabel.Size = new System.Drawing.Size(82, 20);
            this.ImportanceLabel.TabIndex = 22;
            this.ImportanceLabel.Text = "Important:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(18, 242);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(119, 20);
            this.TimeLabel.TabIndex = 21;
            this.TimeLabel.Text = "Reserved Time:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(44, 166);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(93, 20);
            this.StatusLabel.TabIndex = 20;
            this.StatusLabel.Text = "Completion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Task Description:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(61, 203);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(76, 20);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "For Date:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(44, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 20);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Task Name:";
            // 
            // ReminderTabPage
            // 
            this.ReminderTabPage.BackColor = System.Drawing.Color.Gainsboro;
            this.ReminderTabPage.Controls.Add(this.ReminderTimePicker);
            this.ReminderTabPage.Controls.Add(this.OptionalReminderCheckBox);
            this.ReminderTabPage.Controls.Add(this.label3);
            this.ReminderTabPage.Controls.Add(this.richTextBox1);
            this.ReminderTabPage.Controls.Add(this.textBox1);
            this.ReminderTabPage.Controls.Add(this.ReminderDateTimePicker);
            this.ReminderTabPage.Controls.Add(this.ImportantReminderCheckBox);
            this.ReminderTabPage.Controls.Add(this.label4);
            this.ReminderTabPage.Controls.Add(this.label5);
            this.ReminderTabPage.Controls.Add(this.label6);
            this.ReminderTabPage.Controls.Add(this.label7);
            this.ReminderTabPage.Location = new System.Drawing.Point(4, 22);
            this.ReminderTabPage.Name = "ReminderTabPage";
            this.ReminderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReminderTabPage.Size = new System.Drawing.Size(791, 325);
            this.ReminderTabPage.TabIndex = 1;
            this.ReminderTabPage.Text = "Reminder";
            // 
            // OptionalReminderCheckBox
            // 
            this.OptionalReminderCheckBox.AutoSize = true;
            this.OptionalReminderCheckBox.Location = new System.Drawing.Point(739, 206);
            this.OptionalReminderCheckBox.Name = "OptionalReminderCheckBox";
            this.OptionalReminderCheckBox.Size = new System.Drawing.Size(40, 17);
            this.OptionalReminderCheckBox.TabIndex = 41;
            this.OptionalReminderCheckBox.Text = "No";
            this.OptionalReminderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(661, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Optional:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(180, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(602, 77);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 38;
            // 
            // ReminderDateTimePicker
            // 
            this.ReminderDateTimePicker.Enabled = false;
            this.ReminderDateTimePicker.Location = new System.Drawing.Point(90, 202);
            this.ReminderDateTimePicker.Name = "ReminderDateTimePicker";
            this.ReminderDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.ReminderDateTimePicker.TabIndex = 37;
            // 
            // ImportantReminderCheckBox
            // 
            this.ImportantReminderCheckBox.AutoSize = true;
            this.ImportantReminderCheckBox.Location = new System.Drawing.Point(445, 206);
            this.ImportantReminderCheckBox.Name = "ImportantReminderCheckBox";
            this.ImportantReminderCheckBox.Size = new System.Drawing.Size(90, 17);
            this.ImportantReminderCheckBox.TabIndex = 36;
            this.ImportantReminderCheckBox.Text = "Not Important";
            this.ImportantReminderCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(357, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Important:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Reminder Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "For Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(46, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Reminder Name:";
            // 
            // ReminderTimePicker
            // 
            this.ReminderTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ReminderTimePicker.Location = new System.Drawing.Point(90, 228);
            this.ReminderTimePicker.Name = "ReminderTimePicker";
            this.ReminderTimePicker.Size = new System.Drawing.Size(95, 20);
            this.ReminderTimePicker.TabIndex = 42;
            // 
            // TaskOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 410);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TaskTabPage.ResumeLayout(false);
            this.TaskTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumeric)).EndInit();
            this.ReminderTabPage.ResumeLayout(false);
            this.ReminderTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TaskTabPage;
        private System.Windows.Forms.CheckBox OptionalTaskCheckBox;
        private System.Windows.Forms.Label OptionalLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TimeNumeric;
        private System.Windows.Forms.DateTimePicker TaskDateTimePicker;
        private System.Windows.Forms.ComboBox CompletionComboBox;
        private System.Windows.Forms.CheckBox ImportantTaskCheckBox;
        private System.Windows.Forms.Label ImportanceLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TabPage ReminderTabPage;
        private System.Windows.Forms.CheckBox OptionalReminderCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker ReminderDateTimePicker;
        private System.Windows.Forms.CheckBox ImportantReminderCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ReminderTimePicker;
    }
}