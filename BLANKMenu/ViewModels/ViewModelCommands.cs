using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BLANKMenu.ViewModels
{
   public class ViewModelCommands : ICommand
    {
       

        private readonly Action<object> _executeAction;
      
        private readonly Predicate<object> _canExecuteAction;

        public ViewModelCommands(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        // // Конструктор с действие и проверка за изпълнение
        public ViewModelCommands(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }



        /*
         Събитието "CanExecuteChanged" се свързва с автоматичния механизъм "CommandManager.RequerySuggested".
         Това събитие се извиква, когато трябва да се провери изпълнимостта на команди, свързани с потребителския интерфейс.
        */

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested  += value; }
            remove { CommandManager.RequerySuggested  -= value; }
        }


        public bool CanExecute(object parameter) 
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }

      
        public void Execute(object parameter) 
        {
            _executeAction(parameter);
        }
    }
}
