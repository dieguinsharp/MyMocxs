using SQLite;
using System;
using TasksAndritz.LogService.Interfaces;
using TasksAndritz.LogService.Model;

namespace TasksAndritz.LogService
{
    public class LogSQLite : ISendLog, IRemoveLog
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

        public void Remove(object sender, EventArgs handler)
        {
            connection.DeleteAll<Log>();
        }

        public void Send(object sender, EventArgs handler)
        {
            var log = sender as Log;
            connection.Insert(log);
        }

        private string DataBasePath()
        {
            string dataBaseName = "MyMocxs.db";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dataBasePath = System.IO.Path.Combine(folderPath, dataBaseName);

            return dataBasePath;
        }
    }
}
