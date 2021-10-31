using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class AuthorPseudonym
    {
        public int PseudonymId { get; set; }
        public virtual Pseudonym Pseudonym { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
