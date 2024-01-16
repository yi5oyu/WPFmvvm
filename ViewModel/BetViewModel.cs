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
    public class BetViewModel : ViewModelBase
    {
        public ICommand ReturnUserCommand { get; }
        public ICommand GotoCanvasCommand { get; }

        public BetViewModel(Login login, NavigationService userViewNavigationService, NavigationService canvasViewNavigationService)
        {
            ReturnUserCommand = new NavigateCommand(userViewNavigationService);

            GotoCanvasCommand = new NavigateCommand(canvasViewNavigationService);
        }
    }
}
