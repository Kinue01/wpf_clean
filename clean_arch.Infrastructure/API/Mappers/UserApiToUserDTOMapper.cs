using clean_arch.Data.DTOs;
using clean_arch.Infrastructure.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_arch.Infrastructure.API.Mappers
{
    internal static class UserApiToUserDTOMapper
    {
        public static UserDTO Map(UserApi user)
        {
            return new UserDTO
                (
                    user.user_id,
                    user.user_login,
                    user.user_password,
                    user.user_role,
                    user.user_email
                );
        }
    }
}
