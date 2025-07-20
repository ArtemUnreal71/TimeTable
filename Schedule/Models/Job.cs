using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public abstract class Job
    {
        public DateTime Day {  get; set; }

        public string Name { get; set; }        

        public string Description { get; set; }

        public bool Important { get; set; }

        public bool Optional { get; set; }

        public JobType Type { get; set; }

        protected Job(DateTime day)
        {
            this.Day = day;
            this.Name = "New";
            this.Important = false;
            this.Optional = false;
        }

        public enum JobType         
        {
            Task,
            Reminder
        }
    }
}
