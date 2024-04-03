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
    public class ItemTypesDataSourceImpl(IDbContextFactory<BikeMarketContext> dbContextFactory) : ItemTypesDataSource
    {
        readonly IDbContextFactory<BikeMarketContext> dbContextFactory = dbContextFactory;

        public async Task<List<ItemTypeDTO>> GetItemTypes()
        {
            using BikeMarketContext db = await dbContextFactory.CreateDbContextAsync();
            List<TbItemType> tbItemTypes = await db.TbItemTypes.ToListAsync();
            List<ItemTypeDTO> res = [];
            foreach (TbItemType tbItemType in tbItemTypes)
            {
                res.Add(TbItemTypeToItemTypeDTOMapper.Map(tbItemType));
            }
            return res;
        }
    }
}
