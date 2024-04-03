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
    internal static class ItemDTOToTbItemMapper
    {
        readonly static BikeMarketContext db = new();

        public static async Task<TbItem> Map(ItemDTO item)
        {
            TbItemType type = await db.TbItemTypes.FirstAsync(x => x.TypeName == item.Item_Type);
            return new TbItem
                (
                    item.Item_Id,
                    item.Item_Name,
                    item.Item_Description,
                    type.TypeId,
                    item.Item_Image
                );
        }
    }
}
