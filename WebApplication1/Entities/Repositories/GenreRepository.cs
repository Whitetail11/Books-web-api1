using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repositories
{
    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationContext context)
            : base(context)
        { }
        public List<Genre> GetGenres()
        {
            return _dbContext.Genres
                .Include(g => g.Books)
                .ThenInclude(b => b.Author)
                .Include(g => g.Books)
                .ThenInclude(b => b.Publisher)
                .ToList();
        }
    }
}
