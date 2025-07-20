using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Schedule
{
    public class Day
    {
        public DateTime Date { get; set;}

        public int TotalTasks { get; set;}

        public int CompletedTasks { get; set;}

        public Day(DateTime date)
        {
            this.Date = date.Date;
            TotalTasks = 0;
            CompletedTasks = 0;
        }

    }
}
