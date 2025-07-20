using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class DayOverviewForm : Form
    {
        private TasksDataSource TasksData { get; set; }

        private RemindersDataSource RemindersData { get; set; }
        private Day Day { get; set; }


        //public List<Task> NewTasks { get; set; } = new List<Task>();
        public DayOverviewForm(Day day, TasksDataSource taskSource, RemindersDataSource reminderSource)
        {
            InitializeComponent();
            this.Day = day;

            InitializeDataGridView();

            this.TasksData = taskSource;
            this.RemindersData = reminderSource;

            this.HeadingLabel.Text = $"Tasks for {this.Day.Date.ToString().Substring(0, 10)}";            

            HeadingLabel.Left = this.Width / 2 - HeadingLabel.Width / 2;

            if (this.Day.Date.Date <= DateTime.Now.Date)
            {
                this.DeleteButton.Visible = false;
                this.AddButton.Visible = false;
            }

            if (this.Day.Date.Date < DateTime.Now.Date)
            {
                this.AddButton.Visible = false;
                this.EditButton.Visible = false;
            }

            this.TasksDataGrid.AutoGenerateColumns = false;
            this.TasksDataGrid.DataSource = TasksData.GetTasksForDay(this.Day.Date.Date.ToString().Substring(0, 10));

            this.TasksDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TaskOverviewForm taskOverview = new TaskOverviewForm(new Task(this.Day.Date), true);

            if (taskOverview.ShowDialog() == DialogResult.OK)
            {
                this.TasksData.AddTask(taskOverview.CurrentTask);
                this.Refresh();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.TasksDataGrid.RowCount > 0)
            {
                Task task = this.TasksDataGrid.CurrentRow.DataBoundItem as Task;
                TaskOverviewForm taskOverview = new TaskOverviewForm(task, false);

                if (taskOverview.ShowDialog() == DialogResult.OK)
                {
                    this.TasksData.EditTask(taskOverview.CurrentTask);
                    this.Refresh();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.TasksDataGrid.RowCount > 0)
            {
                Task task = this.TasksDataGrid.CurrentRow.DataBoundItem as Task;
                ConfirmationForm popUp = new ConfirmationForm($"Are you sure you want to delete {task.Name} task?");

                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    this.TasksData.RemoveTask(task);
                    this.Refresh();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh()
        {
            this.TasksDataGrid.DataSource = this.TasksData.GetTasksForDay(this.Day.Date.ToString().Substring(0, 10));
        }

        private void TasksDataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = TasksDataGrid.Rows[e.RowIndex];
            Task t = row.DataBoundItem as Task;

            if (t.Optional)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.LightBlue;
                }
            else if (t.Status == Task.State.Complete)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.LightGreen;
                }
            else if (t.Important)
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.FromArgb(250, 218, 94);
                }            
        }

        private void InitializeDataGridView()
        {
            if (this.Day.Date.Date >= DateTime.Now.Date)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "CountdownButton";
                buttonColumn.HeaderText = "Countdown";
                buttonColumn.Text = "Start";
                buttonColumn.UseColumnTextForButtonValue = true;

                this.TasksDataGrid.Columns.Add(buttonColumn);

                this.TasksDataGrid.CellContentClick += StartTimer_ButtonClick;
            }
            else 
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "TimeLeftColumn";
                col.HeaderText = "Time Left";
                col.DataPropertyName = "TimeLeft";
                this.TasksDataGrid.Columns.Add(col);
            }
        }

        private void StartTimer_ButtonClick(object sender, DataGridViewCellEventArgs e)
        {
            Task t = this.TasksDataGrid.CurrentRow.DataBoundItem as Task;

            if (this.TasksDataGrid.CurrentCell == this.TasksDataGrid.CurrentRow.Cells[4])
            {
                if (t.Status == Task.State.Complete)
                {
                    MessageBox.Show("This task is already done!");
                    return;
                }

                CountdownForm countdownForm = new CountdownForm(t.TimeLeft, t.Name);
                countdownForm.ShowDialog();
                if (countdownForm.SecondsLeft >= 10)
                    countdownForm.MinutesLeft += 1;
                t.TimeLeft = countdownForm.MinutesLeft;

                int? compare = t.Time - t.TimeLeft;

                if (t.TimeLeft == 0)
                    t.Status = (Task.State)4;
                else if (compare >= t.Time * 3 / 4)
                    t.Status = (Task.State)3;
                else if (compare >= t.TimeLeft / 2)
                    t.Status = (Task.State)2;
                else if (compare >= t.Time / 4)
                    t.Status = (Task.State)1;

                this.TasksData.EditTask(t);
                Refresh();
            }
        }
    }
}
