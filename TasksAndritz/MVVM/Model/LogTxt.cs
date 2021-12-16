using System;
using System.Collections.Generic;
using System.IO;
using TasksAndritz.MVVM.Interfaces;

namespace TasksAndritz.MVVM.Model
{
    public class LogTxt : IServiceLog, IRemoveLog
    {
        public IEnumerable<Log> Logs()
        {
            var logs = new List<Log>();
            if (!File.Exists("Logs.txt"))
            {
                File.Create("Logs.txt");
            }
            else
            {
                using StreamReader reader = new StreamReader("Logs.txt");
                string text = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(text))
                {
                    string[] logsObj = text.Split('n');
                    foreach (var logObj in logsObj)
                    {
                        string[] obj = logObj.Split('|');
                        logs.Add(new Log()
                        {
                            Id = Convert.ToInt32(obj[0]),
                            Mocx = obj[1],
                            TypeLog = (TypeLog)Convert.ToInt32(obj[2])
                        });
                    }
                } 
            }

            return logs;  
        }

        public void Remove()
        {
            File.Delete("Logs.txt");
        }

        public async void Send(object sender, EventArgs handler)
        {
            var log = sender as Log;
            using StreamWriter writer = new StreamWriter("Logs.txt", append: true);       
            await writer.WriteLineAsync(string.Concat(log.Id, "|", log.Mocx, "|", (int)log.TypeLog));
        }
    }
}
