using System;
using System.Collections.Generic;
using System.Text;
using TasksAndritz.MVVM.Model;

namespace TasksAndritz.MVVM.Interfaces
{
    public interface IServiceLog
    {
        void Send(object sender, EventArgs handler);
    }

    public interface IRemoveLog
    {
        void Remove();
    }
}
