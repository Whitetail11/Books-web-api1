using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public interface IGenreRepository : IRepository<Genre>
    {
        List<Genre> GetGenres();
    }
}
