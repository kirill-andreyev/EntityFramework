<<<<<<< HEAD
﻿using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
=======
﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
>>>>>>> 5a5b237888378951ddd6d6eab27f981ff5ba4976

namespace ConsoleApp1
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
        public DbSet<AuthorPseudonym> AuthorPseudonyms { get; set; }
        public DbSet<AuthorWork> AuthorWorks { get; set; }
        public DbSet<Bookstory> Bookstories { get; set; }
        public DbSet<JournalPublication> JournalPublications { get; set; }
        public DbSet<Pseudonym> Pseudonyms { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkWork> WorkWorks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasIndex(a => a.AuthorName).HasDatabaseName("a_name_idx");
            modelBuilder.Entity<AuthorPseudonym>().HasKey(p => p.PseudonymId);
            modelBuilder.Entity<AuthorWork>().HasKey(a => a.AuthorId);
            modelBuilder.Entity<Bookstory>().HasKey(b => b.BookId);
            modelBuilder.Entity<WorkWork>().HasKey(w => new {w.WorkId, w.WorkId1 });
            modelBuilder.Entity<WorkWork>().HasOne(w => w.Work).WithMany(W => W.WorkWork);
        }
    }
}