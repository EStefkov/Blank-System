using BLANKMenu.Models;
using BLANKMenu.ViewModels;
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
using System.Windows.Shapes;

namespace BLANKMenu.Views
{
    /// <summary>
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {

       

        public TableWindow()
        {
            InitializeComponent();
        }

        public TableModel NewTable { get; private set; }

       

        private void newTableButton_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();

            main.Show();

        }

    }
}
