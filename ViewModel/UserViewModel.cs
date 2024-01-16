using MVVMLoginDB.Command;
using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLoginDB.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public ICommand AdminCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand BetCommand { get; }

        public UserViewModel(Login login, NavigationService adminViewNavigationService, NavigationService loginViewNavigationService
                                , NavigationService betViewNavigationService)
        {
            AdminCommand = new NavigateCommand(adminViewNavigationService);
            ExitCommand = new NavigateCommand(loginViewNavigationService);
            BetCommand = new NavigateCommand(betViewNavigationService);
        }

    }
}
