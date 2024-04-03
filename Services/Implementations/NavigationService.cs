using clean_arch.View.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.View.Services.Implementations
{
    class NavigationService : ObservableObject, INavigationService
    {
        private ObservableObject _currentView;
        private readonly Func<Type, ObservableObject> _viewModelFactory;

        public ObservableObject CurrentView 
        { 
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        public NavigationService(Func<Type, ObservableObject> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : ObservableObject
        {
            ObservableObject viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModel;
        }
    }
}
