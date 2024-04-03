using clean_arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.Repositories
{
    public interface ItemsRepository
    {
        Task<List<Item>> GetItems();
        Task<bool> AddItem(Item item);
    }
}
