using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class JournalPublication
    {
        public int JournalPublicationId { get; set; }
        public int WorkId { get; set; }
        public string JournalName { get; set; }
        public int Release { get; set; }
        public DateTime PubDate { get; set; }
        public int Pages { get; set; }
        public string Quality { get; set; }

        public Work work { get; set; }
    }
}
