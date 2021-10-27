using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Autor autor1 = new Autor { autorName = "Debil", birth = new DateTime(1991,1,1), originalName = "Me" };
                Autor autor2 = new Autor { autorName = "Norm", birth = new DateTime(1996, 1 ,23), originalName = "Test" };

                db.Autors.AddRange(autor1, autor2);
                db.SaveChanges();
            }
        }
    }
}
