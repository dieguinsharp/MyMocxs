using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TasksAndritz.Extensions;

namespace TasksAndritz.LogService.Model
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
                return !string.IsNullOrEmpty(Mocx) ? $"MOCX-{Mocx} {TypeLog.GetDisplayName()}" : TypeLog.GetDisplayName();
            }
        }

        public Log() { }
        public Log(TypeLog typeLog, string mocx = "")
        {
            this.Mocx = mocx;
            this.TypeLog = typeLog;
        }
    }

    public enum TypeLog
    {
        [Display(Name = "was removed")]
        Remove = 0,
        [Display(Name = "was added")]
        Add = 1,
        [Display(Name = "was updated")]
        Update = 2,
        [Display(Name = "Logs was removed")]
        RemoveLogs = 3
    }
}
