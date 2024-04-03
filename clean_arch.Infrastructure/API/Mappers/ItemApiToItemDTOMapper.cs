using clean_arch.Data.DTOs;
using clean_arch.Infrastructure.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Mappers
{
    internal static class ItemApiToItemDTOMapper
    {
        public static ItemDTO Map(ItemApi item)
        {
            return new ItemDTO
                (
                    item.item_id,
                    item.item_name,
                    item.item_description,
                    item.item_type,
                    item.item_image
                );
        }
    }
}
