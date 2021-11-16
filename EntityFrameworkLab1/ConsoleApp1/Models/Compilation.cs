using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{ 
    public class Compilation
    {
        public int Id { get; set; }
        public IList<Work> WorkList { get; set; }
        public WorkDescription WorkDescription { get; set; }
    }
}
