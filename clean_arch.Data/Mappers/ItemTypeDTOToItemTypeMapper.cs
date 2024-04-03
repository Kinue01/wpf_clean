using clean_arch.Data.DTOs;
using clean_arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.Mappers
{
    internal static class ItemTypeDTOToItemTypeMapper
    {
        public static ItemType Map(ItemTypeDTO itemTypeDTO)
        {
            return new ItemType
                (
                    itemTypeDTO.Type_Id,
                    itemTypeDTO.Type_Name
                );
        }
    }
}
