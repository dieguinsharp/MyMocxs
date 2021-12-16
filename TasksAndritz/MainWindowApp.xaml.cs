using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TasksAndritz.MVVM.ViewModel;

namespace TasksAndritz
{
    /// <summary>
    /// Interaction logic for MainWindowApp.xaml
    /// </summary>
    public partial class MainWindowApp : Window
    {
        private readonly MainViewModel _mainViewModel;
        public MainWindowApp(MainViewModel mainViewModel)
        {
            InitializeComponent();
            DataContext = _mainViewModel = mainViewModel;
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.Background = new SolidColorBrush(Color.FromRgb(34, 32, 47));
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            var border = sender as Border;
            border.Background = Brushes.Transparent;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _mainViewModel.AddMocxCommand.Execute(null);
        }
    }
}
