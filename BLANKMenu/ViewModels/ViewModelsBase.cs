using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BLANKMenu.ViewModels
{
    public abstract class ViewModelsBase : INotifyPropertyChanged
    {

       
        /*Събитието PropertyChanged:
         *Това е събитие (event), което се дефинира в интерфейса INotifyPropertyChanged. Този интерфейс се използва обикновено в MVVM,
         *за да се уведоми изгледите за промени в ViewModel или модела.
         */
        public event PropertyChangedEventHandler PropertyChanged;


        /*Този метод се извиква, за да генерира събитието PropertyChanged. Когато свойството на ViewModel се промени, извикването
         * на този метод уведомява всички слушатели (изгледите/views), че е настъпила промяна.
         * Параметърът propertyName указва името на промененото свойство, което позволява на изгледите да разберат, кое свойство се е променило.
         */
        public void OnPropertyChanged(string propertyName) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
  
    }
}
