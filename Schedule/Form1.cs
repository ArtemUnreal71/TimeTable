using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Schedule
{
    public partial class CalendarForm : Form
    {
        private TasksDataSource TasksData { get; set; } = new TasksDataSource();

        private RemindersDataSource RemindersData { get; set; } = new RemindersDataSource();

        private DaysDataSource DaysData { get; set; } = new DaysDataSource();

        private string CurrentDate { get; set; } = DateTime.Now.Date.ToString();

        public CalendarForm()
        {
            InitializeComponent();

            this.JobsDataGrid.AutoGenerateColumns = false;
            this.DaysDataGrid.AutoGenerateColumns = false;

            this.TitleLabel.Left = this.Width / 2 - this.TitleLabel.Width / 2;

            this.DaysDataGrid.DataSource = DaysData.GetList();
            FindRow(CurrentDate);

            BindingList<Job> jobs = new BindingList<Job>();

            foreach (Task task in TasksData.GetTasksForDay(CurrentDate.Substring(0, 10)))
            {
                jobs.Add(task);
            }
            foreach (Reminder reminder in RemindersData.GetRemindersForDay(CurrentDate.Substring(0, 10)))
            {
                jobs.Add(reminder);
            }
            
            this.JobsDataGrid.DataSource = jobs;
            this.DaysDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.JobsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CalculateStreak();
        }

        private void FindDayButton_Click(object sender, EventArgs e)
        {
            string date = this.DatePicker.Value.Date.ToString();
            FindRow(date);
        }

        private void FindRow(string date)
        {
            foreach (DataGridViewRow row in this.DaysDataGrid.Rows)
            {
                if (row.Cells[0].Value.ToString() == date)
                {
                    this.DaysDataGrid.CurrentCell = row.Cells[0];
                    this.DaysDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    this.CurrentDate = this.DaysDataGrid.CurrentRow.Cells[0].Value.ToString().Substring(0, 10);
                    break;
                }
            }
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.CurrentDate = this.DaysDataGrid.CurrentRow.Cells[0].Value.ToString().Substring(0, 10);
            this.JobsDataGrid.DataSource = this.TasksData.GetTasksForDay(CurrentDate);
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DaysData.Save();
        }

        private void DayOverviewButton_Click(object sender, EventArgs e)
        {
            Day d = this.DaysDataGrid.CurrentRow.DataBoundItem as Day;
            DayOverviewForm dayForm = new DayOverviewForm(d, this.TasksData, this.RemindersData);
            dayForm.ShowDialog();
            Refresh();
            DaysData.EditDay(d, this.TasksData.GetTasksForDay(CurrentDate).Where(x => x.Optional == false).Count(), this.TasksData.GetTasksForDay(CurrentDate).Where(x => x.Status == Task.State.Complete && x.Optional == false).Count());
        }

        private void Refresh()
        {
            this.DaysDataGrid.DataSource = this.DaysData.GetList();
            this.JobsDataGrid.DataSource = this.TasksData.GetTasksForDay(CurrentDate);
        }

        private void CalculateStreak()
        {

            bool allCompleted = true;
            int clearStreak = 0;
            int dirtyStreak = 0;
            while (allCompleted)
            {
                int index = Math.Max(dirtyStreak, clearStreak);
                DataGridViewRow r = this.DaysDataGrid.Rows[DaysDataGrid.CurrentRow.Index - index - 1];

                if (Convert.ToInt16(r.Cells[1].Value) != 0)
                {
                    if (Convert.ToInt16(r.Cells[1].Value) == Convert.ToInt16(r.Cells[2].Value))
                    {
                        if (clearStreak == dirtyStreak)
                            clearStreak++;
                        dirtyStreak++;
                    }
                    else if (Convert.ToInt16(r.Cells[1].Value) - Convert.ToInt16(r.Cells[2].Value) < 3)
                    {
                        dirtyStreak++;
                    }
                    else
                        allCompleted = false;
                }
                else
                {
                    allCompleted = false;
                }
            }

            this.ClearStreakCountLabel.Text = clearStreak.ToString();
            this.DirtyStreakCountLabel.Text = dirtyStreak.ToString();
        }

        private void DaysDataGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = DaysDataGrid.Rows[e.RowIndex];
            if (Convert.ToInt16(row.Cells[1].Value) != 0)
                switch (Convert.ToInt32(row.Cells[1].Value) - Convert.ToInt32(row.Cells[2].Value))
                {
                    case 0:
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        break;

                    case 1:
                    case 2:
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.FromArgb(255, 197, 148);
                        }
                        break;

                    default:
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.Style.BackColor = Color.FromArgb(197, 61, 70);
                        }
                        break;
                }
            else
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
        }
    }
}
