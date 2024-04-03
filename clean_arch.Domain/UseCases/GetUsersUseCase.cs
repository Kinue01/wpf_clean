using clean_arch.Domain.Models;
using clean_arch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.UseCases
{
    public class GetUsersUseCase(UsersRepository usersRepository)
    {
        UsersRepository usersRepository = usersRepository;

        public async Task<List<User>> Execute()
        {
            return await usersRepository.GetUsers();
        }
    }
}
