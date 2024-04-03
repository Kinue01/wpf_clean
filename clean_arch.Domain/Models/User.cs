using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Domain.Models
{
    public class User
    {
        public int User_Id { get; set; }
        public string? User_Login { get; set;}
        public string? User_Password { get; set; }
        public string? User_Role { get; set; }
        public string? User_Email { get; set; }

        public User(int user_Id, string? user_Login, string? user_Password, string? user_Role, string? user_Email)
        {
            User_Id = user_Id;
            User_Login = user_Login;
            User_Password = user_Password;
            User_Role = user_Role;
            User_Email = user_Email;
        }
    }
}
