using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.Models
{
    public class Role
    {
        public int Role_Id { get; set; }
        public string? Role_Name { get; set; }

        public Role(int Role_Id, string? Role_name)
        {
            this.Role_Id = Role_Id;
            Role_Name = Role_name;
        }
    }
}
