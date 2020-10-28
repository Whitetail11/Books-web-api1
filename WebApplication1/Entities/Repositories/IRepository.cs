using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    }
}
