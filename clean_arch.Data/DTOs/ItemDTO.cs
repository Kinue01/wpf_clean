using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.DTOs
{
    public class ItemDTO
    {
        public int Item_Id { get; set; }
        public string? Item_Name { get; set; }
        public string? Item_Description { get; set; }
        public string? Item_Type { get; set; }
        public string? Item_Image { get; set; }

        public ItemDTO(int id, string name, string desc, string type, string image) 
        {
            Item_Id = id;
            Item_Name = name;
            Item_Description = desc;
            Item_Type = type;
            Item_Image = image;
        }
    }
}
