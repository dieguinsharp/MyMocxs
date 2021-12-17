using System;
using System.Collections.Generic;
using System.Text;
using TasksAndritz.MVVM.Model;

namespace TasksAndritz.LogService.Interfaces
{
    public interface ISendLog
    {
        void Send(object sender, EventArgs handler);
    }

    public interface IRemoveLog
    {
        void Remove(object sender, EventArgs handler);
    }
}
