using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class RemindersDataSource : IListSource
    {
        private BindingList<Reminder> Reminders { get; set; } = new BindingList<Reminder>();

        public bool ContainsListCollection => true;


        public RemindersDataSource()
        {
            FileInfo file = new FileInfo(Paths.RemindersSavePath);
            if (!file.Exists)
            {
                using (file.Create()) { }

                using (StreamWriter sw = new StreamWriter(Paths.RemindersSavePath))
                {
                    sw.WriteLine("[]");
                }
            }

            Refresh();
        }


        public IList GetList()
        {
            return this.Reminders;
        }

        public BindingList<Reminder> GetRemindersForDay(string date)
        {
            return new BindingList<Reminder>(this.Reminders.Where(x => x.Day.Date.ToString().Substring(0, 10) == date).ToList());
        }

        public void Refresh()
        {
            using (StreamReader sr = new StreamReader(Paths.RemindersSavePath))
            {
                List<Reminder> tasks = JsonConvert.DeserializeObject<List<Reminder>>(sr.ReadLine());

                if (tasks != null)
                    this.Reminders= new BindingList<Reminder>(tasks);
            }
        }
    }
}
