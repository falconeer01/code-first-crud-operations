using DatabaseExample.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Entities
{
    public class Student : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string? Number { get; set; }
        public byte Marks { get; set; }
        public byte Absenteeism { get; set; }
        public virtual User? User { get; set; }
    }
}
