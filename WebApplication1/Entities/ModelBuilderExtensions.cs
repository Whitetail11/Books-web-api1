using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Фэнтези"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Художественная"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Научно-популярная"
                }
                );
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher
                {
                    Id = 1,
                    Name = "Одуванчик"
                },
                new Publisher
                {
                    Id = 2,
                    Name = "Ласточка"
                }
                );
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Вася"
                },
                new Author
                {
                    Id = 2,
                    Name = "Петя"
                },
                new Author
                {
                    Id = 3,
                    Name = "Саша"
                }
                );
        }
    }
}
