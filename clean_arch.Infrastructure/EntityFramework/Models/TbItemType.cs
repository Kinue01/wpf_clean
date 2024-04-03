using System;
using System.Collections.Generic;

namespace clean_arch.Infrastructure.EntityFramework.Models;

public partial class TbItemType
{
    public int TypeId { get; set; }

    public string? TypeName { get; set; }

    public virtual ICollection<TbItem> TbItems { get; set; } = new List<TbItem>();
}
