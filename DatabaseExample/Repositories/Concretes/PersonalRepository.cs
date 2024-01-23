using DatabaseExample.Core;
using DatabaseExample.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample.Repositories.Concretes
{
    public class PersonalRepository : BaseRepository<Personal>
    {
        public PersonalRepository() { }

        public IList<Personal> GetAll(Expression<Func<Personal, bool>>? predicate = null)
        {
            return context.Personals.Include(personal => personal.User).ToList();
        }
    }
}
