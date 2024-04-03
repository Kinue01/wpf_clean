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
    public class ItemTypesRepositoryImpl(ItemTypesDataSource itemTypesDataSource) : ItemTypesRepository
    {
        readonly ItemTypesDataSource itemTypesDataSource = itemTypesDataSource;

        public async Task<List<ItemType>> GetItemTypes()
        {
            List<ItemTypeDTO> items = await itemTypesDataSource.GetItemTypes();
            List<ItemType> res = [];
            foreach(ItemTypeDTO itemType in items)
            {
                res.Add(ItemTypeDTOToItemTypeMapper.Map(itemType));
            }
            return res;
        }
    }
}
