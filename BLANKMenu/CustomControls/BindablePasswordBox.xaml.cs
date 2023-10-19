using BLANKMenu.ViewModels;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BLANKMenu.CustomControls
{
    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {

        /*
        Статичното поле "PasswordProperty" представлява зависимост на свойство (DependencyProperty), което се използва в контрола "BindablePasswordBox".
         Този вид зависимост на свойство се използва, за да се свърже "Password" свойството на "BindablePasswordBox" със стойност от тип "SecureString".
        Този механизъм позволява управлението на стойностите на пароли, като се осигурява по-голяма сигурност при работа с пароли.
        */
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register("Password",typeof(SecureString),typeof(BindablePasswordBox));
        
        /*
       Свойството "Password" представлява паролата, свързана с контрола "BindablePasswordBox". То използва стойността на зависимостното
       свойство "PasswordProperty" и позволява получаване и задаване на паролата, като връща или задава стойност от тип "SecureString".
       Този подход позволява сигурно съхранение на пароли и предпазва от нежелано излагане на паролите в паметта на системата.
        */
        public SecureString Password 
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set {SetValue(PasswordProperty, value); }
        }
        public BindablePasswordBox()
        {
            InitializeComponent();
            txtPassword.PasswordChanged += OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e) 
        {
            Password = txtPassword.SecurePassword;
        }

        private void txtPasswordd(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (DataContext is LoginViewModel viewModel && viewModel.LoginCommand.CanExecute(null))
                {
                    viewModel.LoginCommand.Execute(null);
                }
            }
        }


    }
}
