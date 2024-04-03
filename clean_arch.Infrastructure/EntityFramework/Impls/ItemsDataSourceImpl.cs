using clean_arch.Data.DTOs;
using clean_arch.Data.Repository;
using clean_arch.Infrastructure.EntityFramework.Mappers;
using clean_arch.Infrastructure.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.EntityFramework.Impls
{
    public class ItemsDataSourceImpl(IDbContextFactory<BikeMarketContext> dbContextFactory) : ItemsDataSource
    {

        readonly IDbContextFactory<BikeMarketContext> dbContextFactory = dbContextFactory;

        public async Task<List<ItemDTO>> GetItems()
        {
            using BikeMarketContext db = await dbContextFactory.CreateDbContextAsync();
            List<TbItem> items = await db.TbItems.ToListAsync();
            List<ItemDTO> result = [];
            foreach (TbItem item in items)
            {
                result.Add(await TbItemToItemDTOMapper.Map(item));
            }
            return result;
        }

        public async Task<bool> AddItem(ItemDTO itemDTO)
        {
            using BikeMarketContext db = await dbContextFactory.CreateDbContextAsync();
            TbItem tbItem = await ItemDTOToTbItemMapper.Map(itemDTO);
            db.TbItems.Add(tbItem);
            if (db.SaveChanges() == 1) return true;
            else return false;
        }
    }
}