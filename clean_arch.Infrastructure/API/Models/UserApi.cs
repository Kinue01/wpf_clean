using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Models
{
    internal class UserApi
    {
        public int user_id { get; set; }
        public string? user_login { get; set; }
        public string? user_password { get; set; }
        public string? user_role { get; set; }
        public string? user_email { get; set; }

        public UserApi(int user_id, string user_login, string user_password, string user_role, string user_email) 
        {
            this.user_id = user_id;
            this.user_login = user_login;
            this.user_password = user_password;
            this.user_role = user_role;
            this.user_email = user_email;
        }
    }
}
