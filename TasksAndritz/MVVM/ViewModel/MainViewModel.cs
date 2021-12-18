using System;
using System.Collections.ObjectModel;
using System.Windows;
using TasksAndritz.Core;
using TasksAndritz.LogService.Model;
using TasksAndritz.MVVM.View;

namespace TasksAndritz.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AddMocxCommand { get; set; }
        public RelayCommand DeleteLogsCommand { get; set; }

        MocxViewModel MocxViewModel { get; set; }
        HomeViewModel HomeViewModel { get; set; }
        View.Mocx MocxView { get;set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

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

        public EventHandler SearchText;
        public EventHandler LoadLog;

        private string _searchTextBox;
        public string SearchTextBox
        {
            get { return _searchTextBox; }
            set
            {
                _searchTextBox = value;
                OnPropertyChanged(nameof(SearchTextBox));
                SearchText?.Invoke(value, new EventArgs());
            }
        }

        public MainViewModel()
        {

            LoadLog += AttLogs;

            HomeViewModel = new HomeViewModel();
            HomeViewModel.AttLog += AttLogs;
            SearchText += HomeViewModel.SearchMocx;

            MocxViewModel = new MocxViewModel();

            HomeViewCommand = new RelayCommand(r => {

                CurrentView = new HomeView(HomeViewModel);

            });

            DeleteLogsCommand = new RelayCommand(r =>
            {
                appRepo.DeleteLogs();
                CreateLog(TypeLog.RemoveLogs);
                LoadLog?.Invoke(this, new EventArgs());
            });

            AddMocxCommand = new RelayCommand(r => GoToMocx(r as Model.Mocx));

            CurrentView = new HomeView(HomeViewModel);
            LoadLog?.Invoke(this, new EventArgs());
        }

        public void GoToMocx(Model.Mocx mocx)
        {

            if(mocx != null)
            {
                MocxViewModel.MocxObj = mocx;
            }

            MocxViewModel.SaveMocxEvent += HomeViewModel.AttDates;
            MocxViewModel.SaveMocxEvent += AttLogs;
            MocxViewModel.SaveMocxEvent += CloseMocx;

            var barTopViewModel = new BarTopCloseMinimizeViewModel()
            {
                CloseCommand = new RelayCommand(r => {
                    MocxView.Close();
                }),
                MinimizeCommand = new RelayCommand(r => {
                    MocxView.WindowState = WindowState.Minimized;
                })
            };

            MocxViewModel.BarTop = new View.BarTopCloseMinimize(barTopViewModel);
            MocxView = new View.Mocx(MocxViewModel);

            MocxView.ShowDialog();
        }

        public void AttLogs(object sender, EventArgs args)
        {
            Logs = new ObservableCollection<Log>(appRepo.Logs());
        }

        public void CloseMocx(object sender, EventArgs args)
        {
            MocxView.Close();
        }
    }
}
