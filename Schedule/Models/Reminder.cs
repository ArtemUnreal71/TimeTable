using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class Reminder : Job
    {
        public TimeSpan Time { get; set; }

        public Reminder(DateTime day) : base(day)
        {
            Time = new TimeSpan(0, 0, 0);
            Type = JobType.Reminder;
        }
    }
}
