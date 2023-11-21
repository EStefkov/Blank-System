using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BLANKMenu.Models;
using BLANKMenu.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLANKMenu.ViewModels
{
   public class MainViewModel: ViewModelsBase
    {
        //fiields 
        /*
        Променливите "_currentUserAccount" и "userRepository" съхраняват информация за потребителския акаунт и репозитория за потребители.
        */

        private UserAccountModel _currentUserAccount;
        private IUserRepository userRepository;

        public ICommand LogoutCommand { get; }
        public ICommand NewTableButton { get; }

        /*
        Свойството "CurrentUserAccount" представлява текущия потребителски акаунт. При задаване на стойност на това свойство, то го обновява
        и извиква метода "OnPropertyChanged", за да уведоми изгледите за промените.
        */

        public UserAccountModel CurrentUserAccount
        {
            get 
            {
            return _currentUserAccount;
            }
            set 
            {
            _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }


        private int row;
        public int Row
        {
            get { return row; }
            set
            {
                if (row != value)
                {
                    row = value;
                    OnPropertyChanged(nameof(Row));
                }
            }
        }

        private int column;
        public int Column
        {
            get { return column; }
            set
            {
                if (column != value)
                {
                    column = value;
                    OnPropertyChanged(nameof(Column));
                }
            }
        }



        /*
        Конструкторът "MainViewModel" се използва за инициализация на ViewModel. Той създава екземпляр на "userRepository" от клас "UserRepository",
        инициализира "CurrentUserAccount" с празен потребителски акаунт.
        След това зарежда текущите данни на потребителя чрез "LoadCurrentUserData".
        */
        public MainViewModel() 
        {
            userRepository=new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            NewTableButton = new ViewModelCommands(NewTableButtonn);
            LogoutCommand = new ViewModelCommands(ExecuteLogoutCommand);
            LoadCurrentUserData();
           
        }

   
        private void NewTableButtonn(object sender)
        {

        }

        /*
        Методът "LoadCurrentUserData" извлича и зарежда текущите данни на потребителя.
        Той започва с извличане на данни за потребителя от "userRepository" чрез името на текущия потребител,
        след което актуализира "CurrentUserAccount" с информацията за потребителя, ако такъв съществува.
        В противен случай се задава подходящо съобщение за грешка.
        */

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Uername = user.Username;
                CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName} ";
                CurrentUserAccount.ProfilePicture = null;
            }
            else 
            {
                CurrentUserAccount.DisplayName="Invalid user, not logged in";
               // Application.Current.Shutdown();
            }
        }

        private void ExecuteLogoutCommand(object obj)
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Uername = string.Empty;
                CurrentUserAccount.DisplayName = string.Empty;
                CurrentUserAccount.ProfilePicture = null;
            }
        }
    }
}
