using System;
using System.Collections.Generic;

namespace ConAppMySqltoMSSQL.Models;

public partial class Actor
{
    public uint ActorId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime LastUpdate { get; set; }
}
