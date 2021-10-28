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
        public virtual Author Author { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
