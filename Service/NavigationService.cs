﻿using MVVMLoginDB.Store;
using MVVMLoginDB.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLoginDB.Service
{
    public class NavigationService
    {
        private readonly NavigationStore navigationStore;
        private readonly Func<ViewModelBase> createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            this.navigationStore = navigationStore;
            this.createViewModel = createViewModel;
        }
        public void Navigate()
        {
            navigationStore.CurrentViewModel = createViewModel();
        }
    }
}
