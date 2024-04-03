using clean_arch.Data.Impls;
using clean_arch.Domain.Models;
using clean_arch.Domain.UseCases;
using clean_arch.Infrastructure.EntityFramework.Impls;
using clean_arch.Infrastructure.EntityFramework.Models;
using clean_arch.View.Services.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.Windows.Input;

namespace clean_arch.View.ViewModels
{
    internal class ItemAddViewModel : ObservableObject
    {
        INavigationService navigationService;
        Item currItem = new(0, "", "", "", "/img/default.png");
        readonly AddItemUseCase addItemUseCase;
        readonly GetItemTypesUseCase getItemTypesUseCase;
        List<ItemType> itemTypes;

        public INavigationService NavigationService
        {
            get => navigationService;
            set => SetProperty(ref navigationService, value);
        }
        public Item CurrentItem
        {
            get => currItem;
            set => SetProperty(ref currItem, value);
        }
        public List<ItemType> ItemTypes
        {
            get => itemTypes;
            set => SetProperty(ref itemTypes, value);
        }

        public ICommand NavigateItemsCommand { get; }
        public IAsyncRelayCommand AddItemCommand { get; }
        public IAsyncRelayCommand GetItemTypesCommand { get; }

        public ItemAddViewModel(INavigationService navigationService, IDbContextFactory<BikeMarketContext> dbContextFactory)
        {
            NavigationService = navigationService;

            addItemUseCase = new AddItemUseCase(new ItemsRepositoryImpl(new ItemsDataSourceImpl(dbContextFactory)));
            getItemTypesUseCase = new GetItemTypesUseCase(new ItemTypesRepositoryImpl(new ItemTypesDataSourceImpl(dbContextFactory)));

            NavigateItemsCommand = new RelayCommand(NavigationService.NavigateTo<ItemsViewModel>);
            AddItemCommand = new AsyncRelayCommand(AddItem);
            GetItemTypesCommand = new AsyncRelayCommand(GetItemTypes);
        }

        async Task AddItem()
        {
            await addItemUseCase.Execute(CurrentItem);
        }
        async Task GetItemTypes()
        {
            ItemTypes = await getItemTypesUseCase.Execute();
        }
    }
}
