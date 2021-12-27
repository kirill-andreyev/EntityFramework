using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace EFLAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                //var author = new Author { AuthorName = "TestAuthor1", Birth = new DateTime(1991, 1, 1), OriginalName = "Testing" };
                //var author2 = new Author { AuthorName = "TestAuthor2", Birth = new DateTime(1996, 1, 23), OriginalName = "Testing-2" };

                //var book1 = new Book { BookName = "New Book 1", Pages = 36, PubDate = new DateTime(1999, 1, 15), Quality = "GOOD" };
                //var book2 = new Book { BookName = "New Book 2", Pages = 240, PubDate = new DateTime(2001, 5, 30), Quality = "DAMAGED" };
                //var book3 = new Book { BookName = "New Book 3", Pages = 13, PubDate = new DateTime(2000, 12, 4), Quality = "GOOD" };
                //var journal = new JournalPublication { JournalName = "New Jounral", Pages = 10, PubDate = new DateTime(1999, 1, 2), Quality = "GREAT" };

                //var work1 = new Work { Author = author, Book = book1, Title = book1.BookName };
                //var work2 = new Work { Author = author, Book = book2, Title = book2.BookName };
                //var work3 = new Work { Author = author2, Book = book3,Title = book3.BookName };
                //var work4 = new Work { Author = author2, JournalPublication = journal, Title = journal.JournalName };

                //db.Authors.UpdateRange(author, author2);
                //db.Books.UpdateRange(book1, book2, book3);
                //db.JournalPublications.UpdateRange(journal);
                //db.Works.UpdateRange(work1, work2, work3);

                //db.SaveChanges();

                //db.Database.ExecuteSqlRaw(@"CREATE VIEW AuthorPublication AS
                //                            SELECT Authors.AuthorName AS AuthorName, 
                //                            COUNT(Works.Id) AS NumberOfPublications
                //                            FROM Works
                //                            INNER JOIN Authors on Authors.Id = Works.AuthorId
                //                            GROUP BY AuthorName");

                //db.SaveChanges();

                //foreach (var work in db.Works)
                //{
                //    if(work.Book.PubDate < new DateTime(2000,1,1))
                //    {
                //        var archive = new Archive { Title = work.Title, AuthorName = work.Author.AuthorName, Date = work.Book.PubDate };
                //        db.Works.Remove(work);
                //        db.Archives.Update(archive);
                //    }
                //}

                //db.SaveChanges();
            }
        }
    }
}