using clean_arch.Data.DTOs;
using clean_arch.Data.Mappers;
using clean_arch.Data.Repository;
using clean_arch.Domain.Models;
using clean_arch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.Impls
{
    public class UsersRepositoryImpl(UsersDataSource usersDataSource) : UsersRepository
    {
        UsersDataSource usersDataSource = usersDataSource;

        public async Task<List<User>> GetUsers()
        {
            List<UserDTO> users =  await usersDataSource.GetUsers();
            List<User> result = new List<User>();
            foreach (UserDTO user in users)
            {
                result.Add(UserDTOToUserMapper.Map(user));
            }
            return result;
        }
    }
}
