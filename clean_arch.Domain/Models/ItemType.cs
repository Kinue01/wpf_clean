using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.Models
{
    public class ItemType
    {
        public int Type_Id { get; set; }
        public string? Type_Name { get; set; }

        public ItemType(int id, string name) 
        {
            Type_Id = id;
            Type_Name = name;
        }
    }
}
