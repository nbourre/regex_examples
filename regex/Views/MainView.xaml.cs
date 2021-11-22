﻿using regex.ViewModels;
using System.Windows;

namespace regex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new MainViewModel();

            DataContext = vm;
        }
    }
}
