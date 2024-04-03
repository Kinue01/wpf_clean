using System;
using System.Collections.Generic;

namespace clean_arch.Infrastructure.EntityFramework.Models;

public partial class DieselSchemaMigration
{
    public string Version { get; set; } = null!;

    public DateTime RunOn { get; set; }
}
