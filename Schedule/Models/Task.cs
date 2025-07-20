using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class Task : Job
    {
        public State Status { get; set; }        
        public int Time { get; set; }
        public int? TimeLeft { get; set; }
        
        public enum State
        {
            Incomplete = 0,
            Quarter = 1,
            Half = 2,
            ThreeQuarters = 3,
            Complete = 4,
        }

        public Task(DateTime day) : base(day)
        {            
            this.Time = 30;
            this.Status = State.Incomplete;
            Type = JobType.Task;
        }
    }
}