using BLANKMenu.Models;
using BLANKMenu.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BLANKMenu.Command;
namespace BLANKMenu.ViewModels
{
    public class TablesViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<TableModel> _tables;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddTableCommand { get; private set; }

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Колекция от масите
        public ObservableCollection<TableModel> Tables
        {
            get { return _tables; }
            set
            {
                if (_tables != value)
                {
                    _tables = value;
                    NotifyPropertyChanged();
                }
            }
        }

        // Конструктор
        public TablesViewModel()
        {
            /*
                       _tables = new ObservableCollection<TableModel>();
                       AddTableCommand = new RelayCommand(AddTable);
            */

                     AddTableCommand = new RelayCommand(AddTableAndOpenWindow);
                       // Инициализиране на колекцията с примерни данни
                       _tables = new ObservableCollection<TableModel>
               {
                   new TableModel { TableNumber = 1, NumberOfSeats = 4, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   new TableModel { TableNumber = 2, NumberOfSeats = 2, Status = "Свободна" },
                   // Добавете други маси според нуждите
                       };
                   //  AddTableCommand = new RelayCommand(AddTable);

        }

        public void AddTableAndOpenWindow()
        {
            // Добавяне на нова маса
            //AddTable(new TableModel { TableNumber = [NewNm], NumberOfSeats = [БройМеста], Status = "Свободна" });

            // Отваряне на TableWindow
         /*   TableWindow tableWindow = new TableWindow();
            tableWindow.Show();*/

            var tableWindow = new TableWindow();
            var result = tableWindow.ShowDialog();
            if (result == true && tableWindow.NewTable != null)
            {
                _tables.Add(tableWindow.NewTable);
            }
        }

        // Метод за уведомяване при промяна на свойство
     

        // Методи за управление на масите (пример: промяна на статуса)
        public void UpdateTableStatus(int tableNumber, string newStatus)
        {
            var table = _tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            if (table != null)
            {
                table.Status = newStatus;
            }
        }

        public void AddTable(int tableNumber, int numberOfSeats)
        {

            var newTable = new TableModel
            {
                TableNumber = tableNumber,
                NumberOfSeats = numberOfSeats,
                Status = "Свободна" // или друг подходящ статус
            };

            // Добавяне на новата маса в колекцията
            _tables.Add(newTable);


            /*
              var tableWindow = new TableWindow();
              var result = tableWindow.ShowDialog();
              if (result == true)
              {
                  _tables.Add(tableWindow.NewTable); // Предполагаме, че tableWindow.NewTable връща TableModel
              }*/
        }

        public void RemoveTable(int tableNumber)
        {
            var table = _tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            if (table != null)
            {
                _tables.Remove(table);
            }
        }

        public void UpdateTable(TableModel updatedTable)
        {
            var table = _tables.FirstOrDefault(t => t.TableNumber == updatedTable.TableNumber);
            if (table != null)
            {
                table.NumberOfSeats = updatedTable.NumberOfSeats;
                table.Status = updatedTable.Status;
            }
        }

    }

}
