using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Models
{
    internal class ItemApi
    {
        public int item_id { get; set; }
        public string? item_name { get; set; }
        public string? item_description { get; set; }
        public string? item_type { get; set; }
        public string? item_image {  get; set; }

        [JsonConstructor]
        public ItemApi(int item_id, string item_name, string item_description, string item_type, string item_image) 
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.item_description = item_description;
            this.item_type = item_type;
            this.item_image = item_image;
        }
    }
}
