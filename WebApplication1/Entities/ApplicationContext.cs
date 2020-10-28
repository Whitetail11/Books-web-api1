using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Books)
                .WithOne(b => b.Genre);
            modelBuilder.Seed();

        }
    }
}
