using clean_arch.Data.DTOs;
using clean_arch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Data.Mappers
{
    internal static class UserDTOToUserMapper
    {

        public static User Map(UserDTO user)
        {
            return new User
                (
                    user.User_Id,
                    user.User_Login,
                    user.User_Password,
                    user.User_Role,
                    user.User_Email
                );
        }
    }
}
