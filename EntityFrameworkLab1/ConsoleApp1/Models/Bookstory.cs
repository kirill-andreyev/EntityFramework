using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bookstory
    {
        public int BookId { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public DateTime PubDate { get; set; }
        public string BookName { get; set; }
        public int Pages { get; set; }
        public string  Quality { get; set; }
    }
}
