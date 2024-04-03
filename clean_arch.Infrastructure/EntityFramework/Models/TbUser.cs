using System;
using System.Collections.Generic;

namespace clean_arch.Infrastructure.EntityFramework.Models;

public partial class TbUser
{
    public int UserId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public int UserRoleId { get; set; }

    public string? UserEmail { get; set; }

    public virtual TbRole UserRole { get; set; } = null!;
}
