using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.View.Services.Interfaces
{
    interface INavigationService
    {
        ObservableObject CurrentView { get; }
        void NavigateTo<T>() where T : ObservableObject;
    }
}
