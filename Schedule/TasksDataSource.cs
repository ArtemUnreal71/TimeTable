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
    public class TasksDataSource : IListSource
    {
        private BindingList<Task> Tasks = new BindingList<Task>();

        public TasksDataSource()
        {
            FileInfo file = new FileInfo(Paths.TasksSavePath);
            if (!file.Exists)
            {
                using (file.Create()) { }

                using (StreamWriter sw = new StreamWriter(Paths.TasksSavePath))
                {
                    sw.WriteLine("[]");
                }
            }

            Refresh();
        }

        public IList GetList()
        {
            return this.Tasks;
        }

        public BindingList<Task> GetTasksForDay(string date) 
        {
            return new BindingList<Task>(this.Tasks.Where(x => x.Day.Date.ToString().Substring(0,10) == date).ToList());
        }

        public bool ContainsListCollection => true;

        public void AddTask(Task task) 
        {
            this.Tasks.Add(task);
            Save();
        }

        public void EditTask(Task task) 
        {
            int taskIdx = this.Tasks.IndexOf(task);
            Task editedItem = this.Tasks[taskIdx];

            editedItem.Name = task.Name;
            editedItem.Description = task.Description;
            editedItem.Status = task.Status;
            editedItem.Time = task.Time;
            editedItem.Important = task.Important;
            this.Tasks.Remove(task);

            this.Tasks.Insert(taskIdx, editedItem);
            Save();
            //Refresh();
        }

        public void RemoveTask(Task task) 
        {
            this.Tasks.Remove(task);
            Save();
            //Refresh();
        }


        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(Paths.TasksSavePath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(this.Tasks));
            }
        }

        public void Refresh() 
        {
            using (StreamReader sr = new StreamReader(Paths.TasksSavePath))
            {
                List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(sr.ReadLine());

                if (tasks != null)
                    this.Tasks = new BindingList<Task>(tasks);
            }
        }
    }
}
