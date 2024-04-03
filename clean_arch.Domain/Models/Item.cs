using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.Models
{
    public class Item
    {
        public int Item_Id { get; set; }
        public string? Item_Name { get; set; }
        public string? Item_Description { get; set; }
        public string? Item_Type { get; set; }
        public string? Item_Image { get; set; }

        public Item(int item_Id, string? item_Name, string? item_Description, string? item_Type, string? item_Image)
        {
            Item_Id = item_Id;
            Item_Name = item_Name;
            Item_Description = item_Description;
            Item_Type = item_Type;
            Item_Image = item_Image;
        }
    }
}
