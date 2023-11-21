using BLANKMenu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BLANKMenu.Repositories;
using System.Threading;
using System.Security.Principal;
using System.Net;

namespace BLANKMenu.ViewModels
{
    public class LoginViewModel : ViewModelsBase
    {
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        /*
        Променливата "userRepository" представлява интерфейс за работа с репозиторий на потребители.
        Този интерфейс позволява извикване на операции за достъп и манипулиране на данни, свързани с потребителски акаунти.
        */
        private IUserRepository userRepository;
        private bool _isLoggedIn;


        /*
        Свойството "IsLoggedIn" указва дали потребителят е в момента влезнал в системата или не.
        При смяна на стойността му, то извиква метода "OnPropertyChanged" за уведомление на изгледите за промяна.
        */

        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set
            {
                _isLoggedIn = value;
                OnPropertyChanged(nameof(IsLoggedIn));
            }
        }

        public string Username
        {
            get 
            {
                return _username;
            }
            set 
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public SecureString Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
 
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
     
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        //Commands
        /*
        Свойствата "LoginCommand," "RecoverPasswordCommand," "ShowPasswordCommand," и "RememberPasswordCommand" представляват команди, 
        които се използват в ViewModel за управление на различни действия в потребителския интерфейс, като влизане в системата, 
        възстановяване на парола, показване на паролата и запомняне на паролата.
        */

        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }
      
        //Конструктор 
        /*
        Конструкторът "LoginViewModel" се използва за инициализация на ViewModel за влизане в системата.
        Той създава обект на "userRepository" от клас "UserRepository" и инициализира няколко команди:
        - "LoginCommand" за изпълнение на вход в системата, с проверка на изпълнимост чрез "CanExecuteLogInCommand".
        - "RecoverPasswordCommand" за изпълнение на възстановяване на парола със зададени параметри.
        */

        public LoginViewModel()

        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommands(ExecuteLoginCommand, CanExecuteLogInCommand);
            RecoverPasswordCommand = new ViewModelCommands(p => ExecuteRecoverPassCommand("", ""));
           

        }


        /*
        Методът "CanExecuteLogInCommand" проверява дали са изпълнени условията за изпълнимост на командата за влизане в системата.
        Връща "true", ако потребителското име (Username) и паролата (Password) отговарят на условията за валидни данни.
        В противен случай, връща "false".
        */

        private bool CanExecuteLogInCommand(object obj) 
        {
            bool validData;

            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 || Password == null || Password.Length < 3  ) {
                
                validData = false;
            } 
            else 
            { 
                validData = true;
            }
            return validData;
        }

       


        /*
        Методът "ExecuteLoginCommand" се извиква при изпълнение на командата за влизане в системата.
        Той проверява валидността на потребителското име и парола чрез "userRepository.AuthenticateUser".
        Ако данните са валидни, задава текущия потребител със съответен "GenericPrincipal" и скрива изгледа.
        В противен случай, задава съобщение за невалидни данни.
        */

        private void ExecuteLoginCommand(object obj) 
        {
            var isValidUser = userRepository.AuthenticateUser(new NetworkCredential(Username, Password));
            if (isValidUser)
            {
                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(Username), null);
                IsViewVisible = false;
            }
            else 
            {
                ErrorMessage = "* Invalid username or password";
            }
        }
        private void Logout() //TOOO DOOOO да се премести в MainView  и да се създаде работеща логика
        {
           
            IsLoggedIn = false;
            IsViewVisible = true;

        }

        private bool ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

    }
}
