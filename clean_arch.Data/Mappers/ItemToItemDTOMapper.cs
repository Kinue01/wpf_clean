using clean_arch.Data.DTOs;
using clean_arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.Mappers
{
    internal class ItemToItemDTOMapper
    {
        public static ItemDTO Map(Item item)
        {
            return new ItemDTO
                (
                    item.Item_Id,
                    item.Item_Name,
                    item.Item_Description,
                    item.Item_Type,
                    item.Item_Image
                );
        }
    }
}
