using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class TaskOverviewForm : Form
    {

        public Task CurrentTask { get; set; }
        public TaskOverviewForm(Task task, bool newTask)
        {
            InitializeComponent();

            this.CurrentTask = task;
            
            this.NameTextBox.Text = this.CurrentTask.Name;
            this.DescriptionRichTextBox.Text = this.CurrentTask.Description;
            this.CompletionComboBox.SelectedIndex = (int)this.CurrentTask.Status;
            this.TaskDateTimePicker.Value = this.CurrentTask.Day;
            this.TimeNumeric.Value = this.CurrentTask.Time;
            this.ImportantTaskCheckBox.Checked = this.CurrentTask.Important;
            this.OptionalTaskCheckBox.Checked = this.CurrentTask.Optional;

            this.CompletionComboBox.Enabled = !newTask;

            if (this.ImportantTaskCheckBox.Checked)
                this.ImportantTaskCheckBox.Text = "Important";
            else
                this.ImportantTaskCheckBox.Text = "Not Important";


            if (this.OptionalTaskCheckBox.Checked)
                this.OptionalTaskCheckBox.Text = "Yes";
            else
                this.OptionalTaskCheckBox.Text = "No";


            if (DateTime.Now.Date >= this.CurrentTask.Day.Date)
            {
                this.NameTextBox.Enabled = false;
                this.TimeNumeric.Enabled = false;
                this.ImportantTaskCheckBox.Enabled = false;
                this.OptionalTaskCheckBox.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.CurrentTask.Name = this.NameTextBox.Text;
            this.CurrentTask.Description = this.DescriptionRichTextBox.Text;
            this.CurrentTask.Status = (Task.State)this.CompletionComboBox.SelectedIndex;
            int? timeBefore = this.CurrentTask.Time;
            this.CurrentTask.Time = (int)this.TimeNumeric.Value;
            if (CurrentTask.TimeLeft == null || this.TimeNumeric.Value != timeBefore)
                this.CurrentTask.TimeLeft = this.CurrentTask.Time;
            this.CurrentTask.Important = this.ImportantTaskCheckBox.Checked;
            this.CurrentTask.Optional = this.OptionalTaskCheckBox.Checked;

            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Validation(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.NameTextBox.Text))
            {
                this.ErrorProvider.SetError(this.NameTextBox, "Set the name of the task!");
                e.Cancel = true;
            }
            else
            {
                this.ErrorProvider.SetError(this.NameTextBox, null);
            }

            if (this.CompletionComboBox.SelectedIndex < (int)this.CurrentTask.Status)
            {
                this.ErrorProvider.SetError(this.CompletionComboBox, "You can't reduce completion of the task!");
                e.Cancel = true;
            }
            else
            {
                this.ErrorProvider.SetError(this.CompletionComboBox, null);
            }
        }

        private void DatePickerValidation(object sender, CancelEventArgs e)
        {
            if (this.TaskDateTimePicker.Value != this.CurrentTask.Day)
            {
                this.ErrorProvider.SetError(this.TaskDateTimePicker, $"You can't change value of day, please select {this.CurrentTask.Day.ToString().Substring(0, 10)} date!");
                e.Cancel = true;
            }
            else
            {
                this.ErrorProvider.SetError(this.TaskDateTimePicker, null);
            }
        }

        private void OptionalCheckBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.ImportantTaskCheckBox.Checked == true && this.OptionalTaskCheckBox.Checked == true)
            {
                this.ErrorProvider.SetError(this.OptionalTaskCheckBox, "Important task can't be also optional!");
                e.Cancel = true;
            }
            else
            {
                this.ErrorProvider.SetError(this.OptionalTaskCheckBox, null);
                e.Cancel = false;
            }
        }

        private void ImportantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ImportantTaskCheckBox.Checked)
                this.ImportantTaskCheckBox.Text = "Important";
            else
                this.ImportantTaskCheckBox.Text = "Not Important";

        }

        private void OptionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OptionalTaskCheckBox.Checked)
                this.OptionalTaskCheckBox.Text = "Yes";
            else
                this.OptionalTaskCheckBox.Text = "No";
        }

    }
}
