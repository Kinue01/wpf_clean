using clean_arch.Data.DTOs;
using clean_arch.Infrastructure.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.EntityFramework.Mappers
{
    internal static class TbItemToItemDTOMapper
    {
        readonly static BikeMarketContext db = new();

        public static async Task<ItemDTO> Map(TbItem item)
        {
            TbItemType type = await db.TbItemTypes.FirstAsync(type => type.TypeId == item.ItemTypeId);
            return new ItemDTO
                (
                    item.ItemId, 
                    item.ItemName,
                    item.ItemDescription,
                    type.TypeName,
                    item.ItemImage
                );
        }
    }
}
