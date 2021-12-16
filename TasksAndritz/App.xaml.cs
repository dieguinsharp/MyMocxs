using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TasksAndritz.MVVM.Interfaces;
using TasksAndritz.MVVM.Model;
using TasksAndritz.MVVM.View;
using TasksAndritz.MVVM.ViewModel;

namespace TasksAndritz
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

            BarTopCloseMinimizeViewModel barTopCloseViewModel = new BarTopCloseMinimizeViewModel()
            {
                CloseCommand = new Core.RelayCommand((r) =>
                {
                    App.Current.MainWindow.Close();
                }),
                MinimizeCommand = new Core.RelayCommand((r) =>
                {
                    App.Current.MainWindow.WindowState = WindowState.Minimized;
                })
            };

            MainViewModel mainViewModel = new MainViewModel();
            mainViewModel.BarTop = new BarTopCloseMinimize(barTopCloseViewModel);

            App.Current.Run(new MainWindowApp(mainViewModel));
        }

        public static string GetDataBasePath()
        {
            string dataBaseName = "MyMocxs.db";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dataBasePath = System.IO.Path.Combine(folderPath, dataBaseName);

            return dataBasePath;
        }
    }
}
