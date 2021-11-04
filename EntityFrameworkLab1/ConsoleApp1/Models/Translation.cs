using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLAB1
{
    public class Translation
    {
        public int TranslationId { get; set; }
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
        public string OriginalAutor { get; set; }
        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public DateTime OriginalDate { get; set; }
        public string Quality { get; set; }
        public int Pages { get; set; }
    }
}
