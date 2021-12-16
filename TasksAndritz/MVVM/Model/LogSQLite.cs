using SQLite;
using System;
using System.Collections.Generic;
using TasksAndritz.MVVM.Interfaces;
using TasksAndritz.Service;

namespace TasksAndritz.MVVM.Model
{
    public class LogSQLite : IServiceLog, IRemoveLog
    {
        private const string nameTableDataBase = "Log";
        private readonly SQLiteConnection connection;
        public LogSQLite()
        {
            this.connection = new SQLiteConnection(this.DataBasePath());
            var exist = connection.GetTableInfo(nameTableDataBase);
            if (exist.Count == 0)
            {
                connection.CreateTable<Log>();
            }
        }

        public IEnumerable<Log> Logs()
        {
            return connection.Table<Log>().OrderByDescending(l => l.Id);
        }

        public void Remove()
        {
            connection.DeleteAll<Log>();
        }

        public void Send(object sender, EventArgs handler)
        {
            var log = sender as Log;
            connection.Insert(log);
        }

        public string DataBasePath()
        {
            string dataBaseName = "MyMocxs.db";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dataBasePath = System.IO.Path.Combine(folderPath, dataBaseName);

            return dataBasePath;
        }
    }
}
