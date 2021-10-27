using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Author autor1 = new Author { AuthorName = "Debil", Birth = new DateTime(1991,1,1), OriginalName = "Me" };
                Author autor2 = new Author { AuthorName = "Norm", Birth = new DateTime(1996, 1 ,23), OriginalName = "Test" };

                db.Authors.AddRange(autor1, autor2);
                db.SaveChanges();
            }
        }
    }
}
