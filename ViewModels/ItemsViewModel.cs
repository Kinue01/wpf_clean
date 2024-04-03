using clean_arch.Data.Impls;
using clean_arch.Domain.Models;
using clean_arch.Domain.UseCases;
using clean_arch.Infrastructure.EntityFramework.Impls;
using clean_arch.Infrastructure.EntityFramework.Models;
using clean_arch.View.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace clean_arch.View.ViewModels
{
    class ItemsViewModel : ObservableObject
    {
        List<Item> items;
        Item currItem;
        INavigationService navigationService;
        GetItemsUseCase getItems;

        public INavigationService NavigationService
        {
            get => navigationService;
            set => SetProperty(ref navigationService, value);
        }

        public List<Item> Items 
        { 
            get => items;
            set => SetProperty(ref items, value);
        }
        public Item CurrentItem
        {
            get => currItem;
            set => SetProperty(ref currItem, value);
        }

        public IAsyncRelayCommand GetItemsCommand { get; }
        public ICommand NavigateAddingCommand { get; }

        public ItemsViewModel(IDbContextFactory<BikeMarketContext> dbContextFactory, INavigationService navigationService) 
        {
            NavigationService = navigationService;

            NavigateAddingCommand = new RelayCommand(NavigationService.NavigateTo<ItemAddViewModel>);

            getItems = new GetItemsUseCase(new ItemsRepositoryImpl(new ItemsDataSourceImpl(dbContextFactory)));
            GetItemsCommand = new AsyncRelayCommand(GetItems);
        }

        async Task GetItems()
        {
            Items = await getItems.Execute();
        }
    }
}
