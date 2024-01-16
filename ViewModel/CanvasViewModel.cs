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
    public class CanvasViewModel : ViewModelBase
    {
        public ICommand ReturnBetCommand { get; }
        
        public CanvasViewModel(Login login, NavigationService betViewNavigationService)
        {
            ReturnBetCommand = new NavigateCommand(betViewNavigationService);
        }
    }
}
