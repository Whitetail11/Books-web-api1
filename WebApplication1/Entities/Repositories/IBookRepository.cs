using Entities.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
