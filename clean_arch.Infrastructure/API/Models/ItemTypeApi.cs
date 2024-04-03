using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Models
{
    internal class ItemTypeApi
    {
        public int type_id { get; set; }
        public string? type_name { get; set; }

        public ItemTypeApi(int type_id, string type_name) 
        {
            this.type_id = type_id;
            this.type_name = type_name;
        }
    }
}
