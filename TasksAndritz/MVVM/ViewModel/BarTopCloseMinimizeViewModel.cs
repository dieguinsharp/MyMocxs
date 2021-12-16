using System;
using System.Collections.Generic;
using System.Text;
using TasksAndritz.Core;

namespace TasksAndritz.MVVM.ViewModel
{
    public class BarTopCloseMinimizeViewModel : ObservableObject
    {
        public RelayCommand CloseCommand { get; set; }
        public RelayCommand MinimizeCommand { get; set; }
    }
}
