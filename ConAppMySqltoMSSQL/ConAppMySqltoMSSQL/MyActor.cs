using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMySqltoMSSQL
{
    internal class MyActor
    {
        public uint ActorId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
