using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public class DaysDataSource : IListSource
    {
        private BindingList<Day> Days = new BindingList<Day>();

        public DaysDataSource()
        {
            FileInfo file = new FileInfo(Paths.DaysSavePath);
            if (!file.Exists)
            {
                using (file.Create()) { }

                using (StreamWriter sw = new StreamWriter(Paths.DaysSavePath)) 
                {
                    sw.WriteLine(JsonConvert.SerializeObject(this.LoadDays()));
                }
            }            
            Refresh();
        }

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Days;
        }

        public List<Day> LoadDays() 
        {
            List<Day> daysTmp = new List<Day>();
            DateTime startDate = DateTime.Parse("Nov 4, 2004");
            DateTime endDate = DateTime.Parse("Nov 4, 2104");

            while (endDate > startDate)
            {
                daysTmp.Add(new Day(startDate.Date));
                startDate = startDate.AddDays(1);
            }

            return daysTmp;
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(Paths.DaysSavePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(this.Days.ToList()));
            }
        }


        public void EditDay(Day day, int totalTasks, int completedTasks) 
        {
            int dayIdx = this.Days.IndexOf(day);
            Day edditedDay = this.Days[dayIdx];

            edditedDay.CompletedTasks = completedTasks;
            edditedDay.TotalTasks = totalTasks;

            this.Days.Insert(dayIdx, edditedDay);
            this.Days.Remove(day);
            this.Save();
        }

        public void Refresh()
        {
            using (StreamReader sr = new StreamReader(Paths.DaysSavePath))
            {
                List<Day> days = JsonConvert.DeserializeObject<List<Day>>(sr.ReadLine());

                if (days != null)
                    this.Days = new BindingList<Day>(days);
            }
        }
    }
}
