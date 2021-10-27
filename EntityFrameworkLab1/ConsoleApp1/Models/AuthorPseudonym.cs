using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthorPseudonym
    {

        public int PseudonymId { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
        public Pseudonym pseudonym { get; set; }
    }
}
