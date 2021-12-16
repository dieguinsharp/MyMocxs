using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using TasksAndritz.Core;
using TasksAndritz.MVVM.Model;

namespace TasksAndritz.MVVM.ViewModel
{
    public class MocxViewModel : ObservableObject
    {

        public RelayCommand SaveMocxCommand { get; set; }

        private object _barTop;
        public object BarTop
        {
            get { return _barTop; }
            set
            {
                _barTop = value;
                OnPropertyChanged(nameof(BarTop));
            }
        }

        private Mocx _mocxObj;
        public Mocx MocxObj
        {
            get { return _mocxObj; }
            set {
                _mocxObj = value;
                OnPropertyChanged(nameof(MocxObj));
            }
        }

        public MocxViewModel()
        {
            MocxObj = new Mocx();
            SaveMocxCommand = new RelayCommand(r => SaveMocx());
        }

        public EventHandler SaveMocxEvent { get; set; }
        public EventHandler UpdateLog { get; set; }

        public void SaveMocx()
        {

            if(string.IsNullOrEmpty(MocxObj.Address) || string.IsNullOrEmpty(MocxObj.Cod))
            {
                MessageBox.Show("Informe as informações corretamente.", "Minhas Mocxs", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                appRepo.SaveMocx(MocxObj);
                MocxObj = new Mocx();
                
                SaveMocxEvent?.Invoke(this, new EventArgs());
                UpdateLog?.Invoke(this, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mocx existente.", "Minhas Mocxs", MessageBoxButton.OK, MessageBoxImage.Warning);
            }        
        }
    }
}
