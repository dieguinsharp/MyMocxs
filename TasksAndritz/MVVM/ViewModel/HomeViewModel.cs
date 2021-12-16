using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using TasksAndritz.Core;
using TasksAndritz.MVVM.Model;

namespace TasksAndritz.MVVM.ViewModel
{
    public class HomeViewModel : ObservableObject
    {
        private ObservableCollection<Mocx> mocx;
        public ObservableCollection<Mocx> Mocxs
        {
            get { return mocx; }
            set
            {
                mocx = value;
                OnPropertyChanged(nameof(Mocxs));
            }
        }

        public EventHandler UpdateLog;

        public RelayCommand OpenMocxCommand { get; set; }
        public RelayCommand DeleteMocxCommand { get; set; }
        
        public HomeViewModel()
        {
            OpenMocxCommand = new RelayCommand(r => GoToMocx(r as Mocx));
            DeleteMocxCommand = new RelayCommand(r => DeleteMocx(r as Mocx));
            AttDates(null, null);
            mocxViewModel = new MocxViewModel();
        }

        MocxViewModel mocxViewModel;
        View.Mocx mocxView;

        public void GoToMocx(Model.Mocx mocx)
        {

            if (mocx != null)
            {
                mocxViewModel.MocxObj = mocx;
            }

            BarTopCloseMinimizeViewModel barTopCloseViewModel = new BarTopCloseMinimizeViewModel()
            {
                CloseCommand = new Core.RelayCommand((r) =>
                {
                    mocxView.Close();
                }),
                MinimizeCommand = new Core.RelayCommand((r) =>
                {
                    mocxView.WindowState = WindowState.Minimized;
                })
            };

            mocxViewModel.SaveMocxEvent += AttDates;
            mocxViewModel.SaveMocxEvent += CloseMocx;

            mocxViewModel.BarTop = new View.BarTopCloseMinimize(barTopCloseViewModel);
            mocxView = new View.Mocx(mocxViewModel);

            mocxView.ShowDialog();
        }

        public void AttDates(object sender, EventArgs args)
        {
            Mocxs = new ObservableCollection<Mocx>(appRepo.GetMocxs());
            UpdateLog?.Invoke(this, new EventArgs());
        }

        public void DeleteMocx(Mocx mocx)
        {
            appRepo.DeleteMocx(mocx.Id);
            AttDates(null, null);
        }

        public void CloseMocx(object sender, EventArgs args)
        {
            mocxView.Close();
        }

        public void SearchMocx(object sender, EventArgs args)
        {
            var textSearch = sender as string;
            if (string.IsNullOrEmpty(textSearch))
            {
                this.AttDates(null, null);
                return;
            }

            this.Mocxs = new ObservableCollection<Model.Mocx>(appRepo.SearchMocxs(textSearch));
        }
    }
}
