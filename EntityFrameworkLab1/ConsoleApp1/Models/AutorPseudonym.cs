using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AutorPseudonym
    {

        public int PseudonymId { get; set; }
        public int AutorId { get; set; }

        public Autor Autor { get; set; }
        public Pseudonym pseudonym { get; set; }
    }
}
