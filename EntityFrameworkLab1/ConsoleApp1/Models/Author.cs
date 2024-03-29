﻿using System.ComponentModel.DataAnnotations;
using System;

namespace EFLAB1
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string OriginalName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public virtual Work Work { get; set; }
    }
}
