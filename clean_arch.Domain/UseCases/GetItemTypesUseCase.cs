using clean_arch.Domain.Models;
using clean_arch.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.UseCases
{
    public class GetItemTypesUseCase(ItemTypesRepository itemTypesRepository)
    {
        readonly ItemTypesRepository itemTypesRepository = itemTypesRepository;

        public async Task<List<ItemType>> Execute()
        {
            return await itemTypesRepository.GetItemTypes();
        }
    }
}
