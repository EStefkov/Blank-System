using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using BLANKMenu.Models;
using BLANKMenu.Repositories;

namespace BLANKMenu.ViewModels
{
   public class MainViewModel: ViewModelsBase
    {
        //fiields 
        private UserAccountModel _currentUserAccount;
        private IUserRepository userRepository;

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
        public MainViewModel() 
        {
            userRepository=new UserRepository();
            CurrentUserAccount = new UserAccountModel();
            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.Uername = user.Username;
                CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName} ;";
                CurrentUserAccount.ProfilePicture = null;
            }
            else 
            {
                CurrentUserAccount.DisplayName="Invalid user, not logged in";
               // Application.Current.Shutdown();
            }
        }
    }
}
