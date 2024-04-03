using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using clean_arch.Domain.Models;
using clean_arch.Data;
using clean_arch.Domain.UseCases;
using clean_arch.Infrastructure.EntityFramework.Impls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using clean_arch.View.Services.Interfaces;

namespace clean_arch.View.ViewModels
{
    internal class NavigationViewModel : ObservableObject
    {
        public INavigationService navigationService;

        public INavigationService NavigationService
        {
            get => navigationService;
            set => SetProperty(ref navigationService, value);
        }

        public ICommand NavigateItemsCommand { get; }
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateUsersCommand { get; }

        public NavigationViewModel(INavigationService navigationService) 
        {
            NavigationService = navigationService;

            NavigateItemsCommand = new RelayCommand(NavigationService.NavigateTo<ItemsViewModel>);
            NavigateHomeCommand = new RelayCommand(NavigationService.NavigateTo<HomeViewModel>);
            NavigateUsersCommand = new RelayCommand(NavigationService.NavigateTo<UsersViewModel>);
        }
    }
}
