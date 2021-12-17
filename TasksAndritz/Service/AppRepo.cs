using System;
using System.Collections.Generic;
using SQLite;
using TasksAndritz.MVVM.Model;

namespace TasksAndritz.Service
{
    public class AppRepo
    {

        private const string nameTableDatabase = "Mocx";

        private readonly SQLiteConnection connection;
        public AppRepo()
        {
            connection = new SQLiteConnection(App.GetDataBasePath());
            ExistDataBaseOrCreate(nameTableDatabase);
        }
        public IEnumerable<Mocx> GetMocxs()
        {
            return connection.Table<Mocx>();
        }
        public void ExistDataBaseOrCreate(string nameTableDataBase, bool forced = false)
        {
            var exist = connection.GetTableInfo(nameTableDataBase);
            if(exist.Count == 0 || forced)
            {
                connection.CreateTable<Mocx>();
            }
        }
        public bool SaveMocx(Mocx mocx)
        {

            if(mocx.Id > 0)
            {
                connection.Update(mocx);
                return true;
            }

            mocx.Date = DateTime.Now;
            connection.Insert(mocx);
            return true;
        }

        public bool DeleteMocx(int idMocx)
        {
            var mocx = GetMocx(idMocx);
            connection.Delete(mocx);

            return true;
        }

        public Mocx GetMocx(int idMocx)
        {
            return connection.Table<Mocx>().FirstOrDefault(m => m.Id == idMocx);
        }

        public IEnumerable<Mocx> SearchMocxs(string searchText)
        {
            return connection.Table<Mocx>().Where(s => s.Cod.Contains(searchText));
        }
    }
}
