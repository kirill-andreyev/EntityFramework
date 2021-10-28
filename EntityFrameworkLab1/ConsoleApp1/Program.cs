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
            using (ApplicationContext db = new ApplicationContext())
            {
                Author author = new Author { AuthorName = "TestAuthor1", Birth = new DateTime(1991,1,1), OriginalName = "Testing" };
                Author author2 = new Author { AuthorName = "TestAuthor2", Birth = new DateTime(1996, 1 ,23), OriginalName = "Testing-2" };

                db.Authors.AddRange(author, author2);
                db.SaveChanges();
            }
        }
    }
}
