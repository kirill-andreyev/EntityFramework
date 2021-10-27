using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            using (ApplicationContext db = new ApplicationContext(connectionString))
            {
                Author author = new Author { AuthorName = "TestAuthor1", Birth = new DateTime(1991,1,1), OriginalName = "Testing" };
                Author author2 = new Author { AuthorName = "TestAuthor2", Birth = new DateTime(1996, 1 ,23), OriginalName = "Testing-2" };

                db.Authors.AddRange(author, author2);
                db.SaveChanges();
            }
        }
    }
}
