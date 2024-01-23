using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Core
{
    public abstract class Entity
    {
    }

    public abstract class Entity<PKey> : Entity
    {
        public PKey? Id { get; set; }
    }
}
