using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Autor> Autors { get; set; }
        public DbSet<AutorPseudonym> AutorPseudonyms { get; set; }
        public DbSet<AutorWork> AutorWorks { get; set; }
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
            modelBuilder.Entity<Autor>().HasIndex(a => a.autorName).HasDatabaseName("a_name_idx");
            modelBuilder.Entity<AutorPseudonym>().HasKey(p => p.PseudonymId);
            modelBuilder.Entity<AutorWork>().HasKey(a => a.AutorId);
            modelBuilder.Entity<Bookstory>().HasKey(b => b.BookId);
            modelBuilder.Entity<WorkWork>().HasKey(w => new {w.WorkId, w.WorkId1 });
        }
    }
}