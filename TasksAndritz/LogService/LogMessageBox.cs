using System;
using System.Windows;
using TasksAndritz.LogService.Interfaces;
using TasksAndritz.LogService.Model;

namespace TasksAndritz.LogService
{
    public class LogMessageBox : ISendLog
    {
        public void Send(object sender, EventArgs handler)
        {
            var log = sender as Log;
            MessageBox.Show(log.Info, "My Mocxs");
        }
    }
}
