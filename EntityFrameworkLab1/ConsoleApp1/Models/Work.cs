using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class Work
    {
        public int WorkId { get; set; }
        public string Title { get; set; }
        public virtual List<WorkWork> WorkWork { get; set; }
        public virtual List<WorkWork> WorkWork1 { get; set; }
    }
}
