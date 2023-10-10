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
        // Fields

        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecuteAction;

        public ViewModelCommands(Action<object> executeAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        //Constructors
        public ViewModelCommands(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }


        //Events

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested  += value; }
            remove { CommandManager.RequerySuggested  -= value; }
        }
        //Methods
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
