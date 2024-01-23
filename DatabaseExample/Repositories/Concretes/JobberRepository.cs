using DatabaseExample.Core;
using DatabaseExample.Entities;
using DatabaseExample.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Repositories.Concretes
{
    public class JobberRepository : BaseRepository<Jobber>, IJobberRepository
    {
        public JobberRepository()
        {
        }
    }
}
