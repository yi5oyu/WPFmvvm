using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using MVVMLoginDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.Command
{
    public class SignUpCommand : CommandBase
    {
        private readonly SignUpViewModel signUpViewModel;
        private readonly Login login;
        private readonly NavigationService adminViewNavigationService;

        public SignUpCommand(SignUpViewModel signUpViewModel, Login login, NavigationService adminViewNavigationService)
        {
            this.signUpViewModel = signUpViewModel;
            this.login = login;
            this.adminViewNavigationService = adminViewNavigationService;
        }

        public override void Execute(object parameter)
        {
            signUpViewModel.Usertype = "Guset";
            Loginfo loginfo = new Loginfo(signUpViewModel.UserID, signUpViewModel.Username, signUpViewModel.Password, signUpViewModel.Usertype); 
            //Usertype에대한 예외필요
            
            login.MakeLoginfo(loginfo);

            adminViewNavigationService.Navigate();
        }
    }
}
