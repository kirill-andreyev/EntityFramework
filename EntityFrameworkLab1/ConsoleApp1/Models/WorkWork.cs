using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class WorkWork
    {
        public int WorkId { get; set; }
        public int WorkId1 { get; set; }
        public virtual Work Work { get; set; }
        public virtual Work Work1 { get; set; }
    }
}
