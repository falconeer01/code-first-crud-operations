using DatabaseExample.Core;
using DatabaseExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Repositories.Abstracts
{
    public interface IUserRepository : IBaseRepository<User>
    {

    }
}