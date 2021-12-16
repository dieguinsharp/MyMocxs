﻿using System;
using System.Collections.Generic;
using System.Text;
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

namespace TasksAndritz.MVVM.View
{
    /// <summary>
    /// Interaction logic for Mocx.xaml
    /// </summary>
    public partial class Mocx : Window
    {
        MocxViewModel _mocxViewModel;
        public Mocx(MocxViewModel mocxViewModel)
        {
            InitializeComponent();
            DataContext = _mocxViewModel = mocxViewModel;
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
    }
}
