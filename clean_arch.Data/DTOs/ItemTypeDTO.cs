using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.DTOs
{
    public class ItemTypeDTO
    {
        public int Type_Id { get; set; }
        public string? Type_Name { get; set; }

        public ItemTypeDTO(int id, string name)
        {
            Type_Id = id;
            Type_Name = name;
        }
    }
}
