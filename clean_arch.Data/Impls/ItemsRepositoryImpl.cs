using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clean_arch.Domain.Repositories;
using clean_arch.Domain.Models;
using clean_arch.Data.Repository;
using clean_arch.Data.DTOs;
using clean_arch.Data.Mappers;

namespace clean_arch.Data.Impls
{
    public class ItemsRepositoryImpl(ItemsDataSource itemsDataSource) : ItemsRepository
    {
        readonly ItemsDataSource itemsDataSource = itemsDataSource;

        public async Task<bool> AddItem(Item item)
        {
            return await itemsDataSource.AddItem(ItemToItemDTOMapper.Map(item));
        }

        public async Task<List<Item>> GetItems()
        {
            List<ItemDTO> items = await itemsDataSource.GetItems();
            List<Item> result = [];
            foreach (ItemDTO item in items)
            {
                result.Add(ItemDTOToItemMapper.Map(item));
            }
            return result;
        }
    }
}
