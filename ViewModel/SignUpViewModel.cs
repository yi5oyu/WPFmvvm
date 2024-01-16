using MVVMLoginDB.Command;
using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using MVVMLoginDB.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLoginDB.ViewModel
{
    public class SignUpViewModel : ViewModelBase
    {
        #region UserID, Username, Password, Usertype 속성/OnPropertyChanged 정의
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; OnPropertyChanged(nameof(UserID)); }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(nameof(Username)); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        private string usertype;

        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; OnPropertyChanged(nameof(Usertype)); }
        }
        #endregion

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public SignUpViewModel(Login login, NavigationService loginViewNavigationService)
        {
            SubmitCommand = new SignUpCommand(this, login, loginViewNavigationService);
            CancelCommand = new NavigateCommand(loginViewNavigationService);
        }

    }
}
