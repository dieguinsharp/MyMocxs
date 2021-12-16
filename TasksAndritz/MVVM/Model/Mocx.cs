using System;
using System.Collections.Generic;
using SQLite;
using TasksAndritz.MVVM.Interfaces;

namespace TasksAndritz.MVVM.Model
{
    [Table("Mocx")]
    public class Mocx
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string Cod { get; set; }

        [Unique]
        public string Address { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"[MOCX {Cod}] - {Address} - Worked: {Date.Date.ToString("dd/MM/yyyy")}";
        }
    }
}
