using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TasksAndritz.LogService;
using TasksAndritz.LogService.Controller;
using TasksAndritz.LogService.Model;
using TasksAndritz.LogService.Interfaces;
using TasksAndritz.MVVM.Model;
using TasksAndritz.SQLiteService;

namespace TasksAndritz.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {

        protected readonly AppRepo appRepo;
        protected readonly LogController logControler;

        public ObservableObject()
        {
            appRepo = new AppRepo("Mocx");
            Logs = new ObservableCollection<Log>();
            logControler = new LogController(SendLogServices, RemoveLogServices);
        }

        public void CreateLog(string cod, TypeLog typeLog)
        {
            logControler.Send(new Log(typeLog, cod));
        }

        public static readonly IEnumerable<ISendLog> SendLogServices = new List<ISendLog>
        {
            new LogSQLite(),
            new LogTxt(), 
            new LogMessageBox()
        };

        public static readonly IEnumerable<IRemoveLog> RemoveLogServices = new List<IRemoveLog>
        {
            new LogSQLite(),
            new LogTxt()
        };

        private ObservableCollection<Log> logs;
        public ObservableCollection<Log> Logs
        {
            get { return logs; }
            set
            {
                logs = value;
                OnPropertyChanged(nameof(Logs));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nameProperty = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
    }
}
