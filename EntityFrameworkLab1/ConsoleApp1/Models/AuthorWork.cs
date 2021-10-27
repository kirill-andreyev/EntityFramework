using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthorWork
    {
        public int AuthorId { get; set; }
        public int WorkId { get; set; }

        public Author Author { get; set; }
        public Work Work { get; set; }
    }
}
