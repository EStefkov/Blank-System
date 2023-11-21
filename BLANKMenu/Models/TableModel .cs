using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLANKMenu.Models
{
    public class TableModel : INotifyPropertyChanged
    {
        private int _tableNumber;
        private int _numberOfSeats;
        private string _status;

        public event PropertyChangedEventHandler PropertyChanged;

        //  свойство за номер на масата
        public int TableNumber
        {
            get { return _tableNumber; }
            set
            {
                if (_tableNumber != value)
                {
                    _tableNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }

        //  свойство за брой места
        public int NumberOfSeats
        {
            get { return _numberOfSeats; }
            set
            {
                if (_numberOfSeats != value)
                {
                    _numberOfSeats = value;
                    NotifyPropertyChanged();
                }
            }
        }

        // свойство за статус на масата (например "Свободна", "Заета", "Резервирана")
        public string Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    NotifyPropertyChanged();
                }
            }
        }

        // Метод за уведомяване при промяна на свойство
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
