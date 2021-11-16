using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class Book
    {
        public int Id { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public DateTime PubDate { get; set; }
        public string BookName { get; set; }
        public int Pages { get; set; }
        public string  Quality { get; set; }
    }
}
