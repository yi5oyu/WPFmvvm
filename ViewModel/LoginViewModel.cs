using MVVMLoginDB.Command;
using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLoginDB.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        #region UserID, Password 속성/OnPropertyChanged 정의
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; OnPropertyChanged(nameof(UserID)); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        #endregion

        public ICommand LoginCommand { get; }
        public ICommand NewSignUpCommand { get; }

        public LoginViewModel(Login login, NavigationService signUpViewNavigationService , NavigationService userViewNavigationService)
        {
            LoginCommand = new NavigateCommand(userViewNavigationService);
            NewSignUpCommand = new NavigateCommand(signUpViewNavigationService);
        }

    }
}
