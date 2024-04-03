using clean_arch.Data.DTOs;
using clean_arch.Data.Repository;
using clean_arch.Infrastructure.API.Mappers;
using clean_arch.Infrastructure.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Impls
{
    public class UsersDataSourceImpl : UsersDataSource
    {
        public async Task<List<UserDTO>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
