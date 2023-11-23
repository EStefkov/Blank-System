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
            
            System.Windows.Forms.Application.Restart();
            this.Close();

        }

        public TableModel NewTable { get; private set; }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            int tableNumber;
            int numberOfSeats;

            // Опит за преобразуване на въведените данни в числа
            bool isTableNumberValid = int.TryParse(TableNumberTextBox.Text, out tableNumber);
            bool isNumberOfSeatsValid = int.TryParse(NumberOfSeatsTextBox.Text, out numberOfSeats);

            if (isTableNumberValid && isNumberOfSeatsValid)
            {
                // Създаване на нова маса с въведените данни
                NewTable = new TableModel
                {
                    TableNumber = tableNumber,
                    NumberOfSeats = numberOfSeats,
                    Status = "Свободна"
                };
            
              //  this.Close ();
                TableWindow tableWindow = new TableWindow();
                tableWindow.Show();
            }
            else
            {
                // Покажете съобщение за грешка, ако въведените данни не са валидни
                MessageBox.Show("Моля, въведете валиден номер на масата и брой места.");
            }
        }
        private void ConfirmButton_Click1(object sender, RoutedEventArgs e)
        {
            if (this.DataContext is TablesViewModel viewModel)
            {
                if (int.TryParse(TableNumberTextBox.Text, out int tableNumber) &&
                    int.TryParse(NumberOfSeatsTextBox.Text, out int numberOfSeats))
                {
                    viewModel.AddTable(tableNumber, numberOfSeats);
                }
                else
                {
                    MessageBox.Show("Моля, въведете валидни стойности за номер на масата и брой места.");
                }
            }
        }


        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TableNumberTextBox.Text, out int tableNumber) &&
                int.TryParse(NumberOfSeatsTextBox.Text, out int numberOfSeats))
            {
                NewTable = new TableModel
                {
                    TableNumber = tableNumber,
                    NumberOfSeats = numberOfSeats,
                    Status = "Свободна"
                };
                
               // this.DialogResult = true;
               // this.Close();
            }
            else
            {
                MessageBox.Show("Моля, въведете валидни стойности.");
            }
        }


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
