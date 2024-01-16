using MVVMLoginDB.Model;
using MVVMLoginDB.Service;
using MVVMLoginDB.Store;
using MVVMLoginDB.View;
using MVVMLoginDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMLoginDB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Login login = new Login(); //로그인에 있는 Add메소드사용위해
        private readonly NavigationStore navigationStore = new NavigationStore();

        protected override void OnStartup(StartupEventArgs e)
        {
            navigationStore.CurrentViewModel = CreateLoginViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private LoginViewModel CreateLoginViewModel()
        {
            return new LoginViewModel(login, new NavigationService(navigationStore, CreateSignUpViewModel), 
                new NavigationService(navigationStore, CreateUserViewModel));
        }

        private UserViewModel CreateUserViewModel()
        {
            return new UserViewModel(login, new NavigationService(navigationStore, CreateAdminViewModel), 
                new NavigationService(navigationStore, CreateLoginViewModel), 
                new NavigationService(navigationStore, CreateBetViewModel));
        }

        private SignUpViewModel CreateSignUpViewModel()
        {
            return new SignUpViewModel(login, new NavigationService(navigationStore, CreateLoginViewModel));
        }

        private AdminViewModel CreateAdminViewModel()
        {
            return new AdminViewModel(login, new NavigationService(navigationStore, CreateUserViewModel));
        }

        private BetViewModel CreateBetViewModel()
        {
            return new BetViewModel(login, new NavigationService(navigationStore, CreateUserViewModel), 
                new NavigationService(navigationStore, CreateCanvasViewModel));
        }

        private CanvasViewModel CreateCanvasViewModel()
        {
            return new CanvasViewModel(login, new NavigationService(navigationStore, CreateBetViewModel));
        }
    }
}
