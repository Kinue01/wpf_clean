using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Models
{
    internal class RoleApi
    {
        public int role_id { get; set; }
        public string? role_name { get; set; }

        public RoleApi(int role_id, string role_name) 
        {
            this.role_id = role_id;
            this.role_name = role_name;
        }
    }
}
