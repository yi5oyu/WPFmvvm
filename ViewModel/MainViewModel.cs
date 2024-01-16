using MVVMLoginDB.Model;
using MVVMLoginDB.Store;
//using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.ViewModel
{
    public class MainViewModel :ViewModelBase
    {
        private readonly NavigationStore navigationStore;
        public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
