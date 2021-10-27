using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AutorWork
    {
        public int AutorId { get; set; }
        public int WorkId { get; set; }

        public Autor Autor { get; set; }
        public Work Work { get; set; }
    }
}
