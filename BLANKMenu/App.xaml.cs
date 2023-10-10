using BLANKMenu.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BLANKMenu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            var LoginWindow = new LoginWindow();
            LoginWindow.Show();
            LoginWindow.IsVisibleChanged += (s, ev) =>
            {
                if (LoginWindow.IsVisible == false && LoginWindow.IsLoaded)
                {
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    LoginWindow.Close();
                }
            };

        }
    }
}
