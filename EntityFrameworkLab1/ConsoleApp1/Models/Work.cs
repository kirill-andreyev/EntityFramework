using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Compilation Compilation { get; set; }
        public virtual Book Book { get; set; }
        public virtual JournalPublication JournalPublication { get; set; }
        public virtual Translation Translation { get; set; }
    }
}
