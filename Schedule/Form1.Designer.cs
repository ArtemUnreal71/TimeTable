namespace Schedule
{
    partial class CalendarForm
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
            this.JobsDataGrid = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DayOverviewButton = new System.Windows.Forms.Button();
            this.DaysDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedTasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindDayButton = new System.Windows.Forms.Button();
            this.FindDateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearStreakLabel = new System.Windows.Forms.Label();
            this.ClearStreakCountLabel = new System.Windows.Forms.Label();
            this.DirtyStreakCountLabel = new System.Windows.Forms.Label();
            this.DirtyStreakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksDataGrid
            // 
            this.JobsDataGrid.AllowUserToAddRows = false;
            this.JobsDataGrid.AllowUserToDeleteRows = false;
            this.JobsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskDescription});
            this.JobsDataGrid.Location = new System.Drawing.Point(363, 85);
            this.JobsDataGrid.Name = "TasksDataGrid";
            this.JobsDataGrid.ReadOnly = true;
            this.JobsDataGrid.Size = new System.Drawing.Size(889, 548);
            this.JobsDataGrid.TabIndex = 1;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Name";
            this.TaskName.MinimumWidth = 50;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 150;
            // 
            // TaskDescription
            // 
            this.TaskDescription.DataPropertyName = "TaskDescription";
            this.TaskDescription.HeaderText = "Description";
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            this.TaskDescription.Width = 695;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(526, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(201, 59);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "My Tasks";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayOverviewButton
            // 
            this.DayOverviewButton.Location = new System.Drawing.Point(363, 641);
            this.DayOverviewButton.Name = "DayOverviewButton";
            this.DayOverviewButton.Size = new System.Drawing.Size(150, 30);
            this.DayOverviewButton.TabIndex = 3;
            this.DayOverviewButton.Text = "Day Overview";
            this.DayOverviewButton.UseVisualStyleBackColor = true;
            this.DayOverviewButton.Click += new System.EventHandler(this.DayOverviewButton_Click);
            // 
            // DaysDataGrid
            // 
            this.DaysDataGrid.AllowUserToAddRows = false;
            this.DaysDataGrid.AllowUserToDeleteRows = false;
            this.DaysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaysDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.TotalTasks,
            this.CompletedTasks});
            this.DaysDataGrid.Location = new System.Drawing.Point(12, 85);
            this.DaysDataGrid.MultiSelect = false;
            this.DaysDataGrid.Name = "DaysDataGrid";
            this.DaysDataGrid.ReadOnly = true;
            this.DaysDataGrid.Size = new System.Drawing.Size(345, 548);
            this.DaysDataGrid.TabIndex = 5;
            this.DaysDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
            this.DaysDataGrid.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DaysDataGrid_RowPrePaint);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Day Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalTasks
            // 
            this.TotalTasks.DataPropertyName = "TotalTasks";
            this.TotalTasks.HeaderText = "Toltal Tasks";
            this.TotalTasks.Name = "TotalTasks";
            this.TotalTasks.ReadOnly = true;
            this.TotalTasks.Width = 90;
            // 
            // CompletedTasks
            // 
            this.CompletedTasks.DataPropertyName = "CompletedTasks";
            this.CompletedTasks.HeaderText = "Completed";
            this.CompletedTasks.Name = "CompletedTasks";
            this.CompletedTasks.ReadOnly = true;
            this.CompletedTasks.Width = 90;
            // 
            // FindDayButton
            // 
            this.FindDayButton.Location = new System.Drawing.Point(254, 641);
            this.FindDayButton.Name = "FindDayButton";
            this.FindDayButton.Size = new System.Drawing.Size(103, 30);
            this.FindDayButton.TabIndex = 6;
            this.FindDayButton.Text = "Find Day";
            this.FindDayButton.UseVisualStyleBackColor = true;
            this.FindDayButton.Click += new System.EventHandler(this.FindDayButton_Click);
            // 
            // FindDateLabel
            // 
            this.FindDateLabel.AutoSize = true;
            this.FindDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindDateLabel.Location = new System.Drawing.Point(12, 645);
            this.FindDateLabel.Name = "FindDateLabel";
            this.FindDateLabel.Size = new System.Drawing.Size(83, 20);
            this.FindDateLabel.TabIndex = 7;
            this.FindDateLabel.Text = "Find Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(102, 644);
            this.DatePicker.MaxDate = new System.DateTime(2104, 11, 4, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2004, 11, 4, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(146, 20);
            this.DatePicker.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1102, 639);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearStreakLabel
            // 
            this.ClearStreakLabel.AutoSize = true;
            this.ClearStreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearStreakLabel.Location = new System.Drawing.Point(15, 57);
            this.ClearStreakLabel.Name = "ClearStreakLabel";
            this.ClearStreakLabel.Size = new System.Drawing.Size(137, 25);
            this.ClearStreakLabel.TabIndex = 9;
            this.ClearStreakLabel.Text = "Clear Streak:";
            // 
            // ClearStreakCountLabel
            // 
            this.ClearStreakCountLabel.AutoSize = true;
            this.ClearStreakCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearStreakCountLabel.Location = new System.Drawing.Point(148, 57);
            this.ClearStreakCountLabel.Name = "ClearStreakCountLabel";
            this.ClearStreakCountLabel.Size = new System.Drawing.Size(24, 25);
            this.ClearStreakCountLabel.TabIndex = 10;
            this.ClearStreakCountLabel.Text = "1";
            // 
            // DirtyStreakCountLabel
            // 
            this.DirtyStreakCountLabel.AutoSize = true;
            this.DirtyStreakCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirtyStreakCountLabel.Location = new System.Drawing.Point(333, 57);
            this.DirtyStreakCountLabel.Name = "DirtyStreakCountLabel";
            this.DirtyStreakCountLabel.Size = new System.Drawing.Size(24, 25);
            this.DirtyStreakCountLabel.TabIndex = 12;
            this.DirtyStreakCountLabel.Text = "1";
            // 
            // DirtyStreakLabel
            // 
            this.DirtyStreakLabel.AutoSize = true;
            this.DirtyStreakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirtyStreakLabel.Location = new System.Drawing.Point(210, 57);
            this.DirtyStreakLabel.Name = "DirtyStreakLabel";
            this.DirtyStreakLabel.Size = new System.Drawing.Size(130, 25);
            this.DirtyStreakLabel.TabIndex = 11;
            this.DirtyStreakLabel.Text = "Dirty Streak:";
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DirtyStreakCountLabel);
            this.Controls.Add(this.DirtyStreakLabel);
            this.Controls.Add(this.ClearStreakCountLabel);
            this.Controls.Add(this.ClearStreakLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.FindDateLabel);
            this.Controls.Add(this.FindDayButton);
            this.Controls.Add(this.DaysDataGrid);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DayOverviewButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.JobsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.JobsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView JobsDataGrid;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button DayOverviewButton;
        private System.Windows.Forms.DataGridView DaysDataGrid;
        private System.Windows.Forms.Button FindDayButton;
        private System.Windows.Forms.Label FindDateLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ClearStreakLabel;
        private System.Windows.Forms.Label ClearStreakCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletedTasks;
        private System.Windows.Forms.Label DirtyStreakCountLabel;
        private System.Windows.Forms.Label DirtyStreakLabel;
    }
}

