using System;
using System.Collections.Generic;
using System.Text;
using TasksAndritz.LogService.Interfaces;
using TasksAndritz.LogService.Model;

namespace TasksAndritz.LogService.Controller
{
    public class LogController
    {
        private readonly EventHandler SendLogs;
        private readonly EventHandler RemoveLogs;

        public LogController(IEnumerable<ISendLog> sendLogs, IEnumerable<IRemoveLog> removeLogs)
        {

            foreach (var sendLog in sendLogs)
            {
                SendLogs += sendLog.Send;
            }

            foreach (var removeLog in removeLogs)
            {
                RemoveLogs += removeLog.Remove;
            }

        }

        public void Send(Log log)
        {
            SendLogs?.Invoke(log, new EventArgs());
        }

        public void RemoveAll(Log log)
        {
            RemoveLogs?.Invoke(log, new EventArgs());
        }
    }
}
