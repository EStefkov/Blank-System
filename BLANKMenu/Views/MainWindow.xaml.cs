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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void RadioButton_Click(object sender, RoutedEventArgs e)//TOO DOO 
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Close();

            System.Windows.Forms.Application.Restart();
        
        }
        /*
         

private void RadioButton_Click_1(object sender, RoutedEventArgs e)
{
    RadioButton radioButton = sender as RadioButton;

    // Променете стойностите на Grid.Row и Grid.Column според текущия ред и колона
    Grid.SetRow(radioButton, currentRow);
    Grid.SetColumn(radioButton, currentColumn);

    // Увеличете текущия ред и колона
    currentColumn++; // Преместване на следващата колона
    if (currentColumn == 5)
    {
        currentColumn = 0; // Върнете се към първата колона, ако сте стигнали до края на реда
        currentRow++; // Преместване на следващия ред
    }

    // Ако сте стигнали до края на всички редове и колони, можете да извършите определени действия, например рестартиране на текущите стойности или известие до потребителя.

    // Отново покажете текущия прозорец
    this.Close();
    TableWindow tableWindow = new TableWindow();
    tableWindow.Show();
}
         
         */
        private int currentRow = 0;
        private int currentColumn = 0;
        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            

            TableWindow tableWindow = new TableWindow();
            this.Close();
            tableWindow.Show();
        }
    }
}
