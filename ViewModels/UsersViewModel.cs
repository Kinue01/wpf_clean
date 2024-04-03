using clean_arch.Data.Impls;
using clean_arch.Domain.Models;
using clean_arch.Domain.UseCases;
using clean_arch.Infrastructure.API.Impls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.View.ViewModels
{
    internal class UsersViewModel : ObservableObject
    {
        List<User> users;
        User currUser;

        public List<User> Users
        {
            get => users;
            set => SetProperty(ref users, value);
        }
        public User CurrentUser
        {
            get => currUser;
            set => SetProperty(ref currUser, value);
        }

        GetUsersUseCase getUsersUseCase;
        public IAsyncRelayCommand GetUsersCommand { get; }

        public UsersViewModel() 
        {
            getUsersUseCase = new GetUsersUseCase(new UsersRepositoryImpl(new UsersDataSourceImpl()));
            GetUsersCommand = new AsyncRelayCommand(GetUsers);
        }

        async Task GetUsers()
        {
            Users = await getUsersUseCase.Execute();
        }
    }
}
