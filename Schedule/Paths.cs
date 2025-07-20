using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public static class Paths
    {
        public static string DaysSavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyTaskManager_Days.txt";
        public static string TasksSavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyTaskManager_Tasks.txt";
        public static string RemindersSavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MyTaskManager_Reminders.txt";
        public static string CompletionAlert = @"D:\Visual Studio\Bigger Projects\Schedule\bin\Debug\Sounds\Completion.wav";        
    }
}
