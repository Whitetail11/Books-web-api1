using Entities.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Entities.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ApplicationContext context)
            : base(context)
        { }
        public void CreateBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .Include(b => b.Publisher)
                .ToList();
        }
        public void UpdateBook(Book book)
        {
            _dbContext.Books.Update(book);
            _dbContext.SaveChanges();
        }
    }
}
