using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace regex
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// Author : nicol
    /// Creation Date : 11/19/2021 3:16:12 PM
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow win = new MainWindow();

            win.Show();
        }
    }
}
