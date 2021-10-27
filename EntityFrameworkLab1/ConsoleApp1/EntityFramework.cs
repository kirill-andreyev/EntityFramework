using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorPseudonym> AuthorPseudonyms { get; set; }
        public DbSet<AuthorWork> AuthorWorks { get; set; }
        public DbSet<Bookstory> Bookstories { get; set; }
        public DbSet<JournalPublication> JournalPublications { get; set; }
        public DbSet<Pseudonym> Pseudonyms { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkWork> WorkWorks { get; set; }
        

        public ApplicationContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=csharplabs;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasIndex(a => a.AuthorName).HasDatabaseName("a_name_idx");
            modelBuilder.Entity<AuthorPseudonym>().HasKey(p => p.PseudonymId);
            modelBuilder.Entity<AuthorWork>().HasKey(a => a.AuthorId);
            modelBuilder.Entity<Bookstory>().HasKey(b => b.BookId);
            modelBuilder.Entity<WorkWork>().HasKey(w => new {w.WorkId, w.WorkId1 });
        }
    }
}