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
                Author author = new Author { AuthorName = "TestAuthor1", Birth = new DateTime(1991, 1, 1), OriginalName = "Testing" };
                Author author2 = new Author { AuthorName = "TestAuthor2", Birth = new DateTime(1996, 1, 23), OriginalName = "Testing-2" };

                Book book1 = new Book { BookName = "New Book 1", Pages = 36, PubDate = new DateTime(1999, 1, 15), Quality = "GOOD" };
                Book book2 = new Book { BookName = "New Book 2", Pages = 240, PubDate = new DateTime(2001, 5, 30), Quality = "DAMAGED" };

                Work work1 = new Work { Author = author, Book = book1, Title = book1.BookName };
                Work work2 = new Work { Author = author, Book = book2, Title = book2.BookName };

                db.Authors.UpdateRange(author, author2);
                db.Books.UpdateRange(book1, book2);
                db.Works.UpdateRange(work1, work2);

                db.SaveChanges();

                foreach (var work in db.Works)
                {
                    if(work.Book.PubDate < new DateTime(2000,1,1))
                    {
                        Archive archive = new Archive { Title = work.Title, AuthorName = work.Author.AuthorName, Date = work.Book.PubDate };
                        db.Works.Remove(work);
                        db.Archives.Update(archive);
                    }
                }

                db.SaveChanges();
            }
        }
    }
}