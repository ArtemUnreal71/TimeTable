using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class CountdownForm : Form
    {
        private SoundPlayer CompletionAlert = new SoundPlayer();
        public int? MinutesLeft { get; set; }
        public int? SecondsLeft { get; set; } = 59;
        public string TaskName { get; set; }

        public CountdownForm(int? minutes, string taskName)
        {
            InitializeComponent();
            CompletionAlert.SoundLocation = Paths.CompletionAlert;
            
            //this.TimeLeftLabel.Left = this.Width / 2 - this.TimeLeftLabel.Width / 2;
            //this.CountdwonLabel.Left = this.TimeLeftLabel.Left + this.TimeLeftLabel.Width + 10;

            if(minutes !=0)
            MinutesLeft = minutes - 1;
            this.CountdwonLabel.Text = $"{MinutesLeft}:{this.SecondsLeft.ToString()}";
            this.TaskName = taskName;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (this.Countdown.Enabled == true)            
                this.PauseButton.Text = "Start";            
            else             
                this.PauseButton.Text = "Pause";
            
            this.Countdown.Enabled = !this.Countdown.Enabled;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Countdown.Stop();
            this.Close();
        }

        private async void Countdown_Tick(object sender, EventArgs e)
        {
            if (this.SecondsLeft-- <= 0)
            {
                this.SecondsLeft = 59;
                
                if (this.MinutesLeft-- <= 0)
                {
                    this.Countdown.Stop();                    
                    CompletionAlert.Play();
                    MessageBox.Show($"{DateTime.Now.TimeOfDay.ToString().Substring(0, 8)}\nTask {this.TaskName} is Done!");
                    this.MinutesLeft = 0;     
                    this.SecondsLeft = 0;
                    this.Close();
                }
            }

            this.CountdwonLabel.Text = $"{MinutesLeft}:{this.SecondsLeft.ToString()}";
        }
    }
}
