﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Work
    {
        public int WorkId { get; set; }
        public string Title { get; set; }
        virtual public List<WorkWork> WorkWork { get; set; }
    }
}
