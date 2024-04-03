using clean_arch.Data.DTOs;
using clean_arch.Infrastructure.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.EntityFramework.Mappers
{
    internal static class TbItemTypeToItemTypeDTOMapper
    {
        public static ItemTypeDTO Map(TbItemType itemType)
        {
            return new ItemTypeDTO
                (
                    itemType.TypeId,
                    itemType.TypeName
                );
        }
    }
}
