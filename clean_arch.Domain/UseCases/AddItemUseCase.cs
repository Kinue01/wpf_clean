using clean_arch.Domain.Models;
using clean_arch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.UseCases
{
    public class AddItemUseCase(ItemsRepository itemRepository)
    {
        readonly ItemsRepository itemRepository = itemRepository;

        public async Task<bool> Execute(Item item)
        {
            return await itemRepository.AddItem(item);
        }
    }
}
