using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace EFLAB1
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString;

        public ApplicationContext()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<JournalPublication> JournalPublications { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasIndex(a => a.AuthorName).HasDatabaseName("a_name_idx");
        }
    }
}