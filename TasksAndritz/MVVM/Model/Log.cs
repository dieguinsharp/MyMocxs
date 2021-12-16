using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TasksAndritz.Extensions;
using TasksAndritz.MVVM.Interfaces;

namespace TasksAndritz.MVVM.Model
{
    [Table("Log")]
    public class Log
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Mocx { get; set; }
        public TypeLog TypeLog { get; set; }
        public string Info
        {
            get
            {
                return "MOCX-" + Mocx + TypeLog.GetDisplayName();
            }
        }

        public EventHandler ServiceLogs;

        public Log() { }
        public Log(IEnumerable<IServiceLog> serviceLogs, string mocx, TypeLog typeLog)
        {
            this.Mocx = mocx;
            this.TypeLog = typeLog;

            foreach (var serviceLog in serviceLogs)
            {
                ServiceLogs += serviceLog.Send;
            }

            ServiceLogs?.Invoke(this, new EventArgs());
        }
    }

    public enum TypeLog
    {
        [Display(Name = " was removed")]
        Remove = 0,
        [Display(Name = " was added")]
        Add = 1,
        [Display(Name = " was updated")]
        Update = 2
    }
}
