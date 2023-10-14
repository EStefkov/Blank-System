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

namespace BLANKMenu
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void VisualBrush_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }


        }
        private void btnMinimize_Click(Object sender,RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }
        
        private void btnLogIn_Click(Object sender, RoutedEventArgs e) {
          
        }
        private void btnClose_Click(Object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
