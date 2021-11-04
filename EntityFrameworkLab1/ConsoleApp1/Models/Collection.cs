using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{ 
    public class Collection
    {
        public int WorkId { get; set; }
        public int Work1Id { get; set; }
        public virtual Work Work { get; set; }
    }
}
