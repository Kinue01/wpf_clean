using System;
using System.Collections.Generic;

namespace clean_arch.Infrastructure.EntityFramework.Models;

public partial class TbItem
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public int ItemTypeId { get; set; }

    public string? ItemImage { get; set; }

    public virtual TbItemType? ItemType { get; set; }

    public TbItem() { }
    public TbItem(int id, string name, string desc, int typeId, string image)
    {
        ItemId = id;
        ItemName = name;
        ItemDescription = desc;
        ItemTypeId = typeId;
        ItemImage = image;
    }
}
