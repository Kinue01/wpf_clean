using clean_arch.Domain.Models;
using clean_arch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.UseCases
{
    public class GetItemsUseCase(ItemsRepository repository)
    {
        ItemsRepository repository = repository;

        public async Task<List<Item>> Execute()
        {
            return await repository.GetItems();
        }
    }
}
