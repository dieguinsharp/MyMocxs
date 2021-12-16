using System;
using System.Windows;
using TasksAndritz.MVVM.Interfaces;

namespace TasksAndritz.MVVM.Model
{
    public class LogMessageBox : IServiceLog
    {
        public void Send(object sender, EventArgs handler)
        {
            var log = sender as Log;
            MessageBox.Show(log.Info, "My Mocxs");
        }
    }
}
