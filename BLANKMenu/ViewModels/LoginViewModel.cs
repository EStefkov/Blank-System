﻿using BLANKMenu.Models;
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
         
        private IUserRepository userRepository;

   
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
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        public LoginViewModel()

        {
            userRepository = new UserRepository();
            LoginCommand = new ViewModelCommands(ExecuteLoginCommand, CanExecuteLogInCommand);
            RecoverPasswordCommand = new ViewModelCommands(p => ExecuteRecoverPassCommand("", ""));
        }

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
        private bool ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

    }
}