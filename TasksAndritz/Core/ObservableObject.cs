using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TasksAndritz.MVVM.Interfaces;
using TasksAndritz.MVVM.Model;
using TasksAndritz.Service;

namespace TasksAndritz.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {

        protected readonly AppRepo appRepo;
        protected readonly LogSQLite logSqliteRepo;
        protected readonly LogTxt logTxtRepo;

        public ObservableObject()
        {
            appRepo = new AppRepo();
            logSqliteRepo = new LogSQLite();
            logTxtRepo = new LogTxt();

            Logs = new ObservableCollection<Log>();
        }

        public static readonly IEnumerable<IServiceLog> LogServices = new List<IServiceLog>
        {
            new LogSQLite(),
            new LogTxt(), 
            new LogMessageBox()
        };

        public static readonly IEnumerable<IRemoveLog> LogRemoveServices = new List<IRemoveLog>
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
