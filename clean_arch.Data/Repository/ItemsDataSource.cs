using clean_arch.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.Repository
{
    public interface ItemsDataSource
    {
        Task<List<ItemDTO>> GetItems();
        Task<bool> AddItem(ItemDTO itemDTO);
    }
}
