using System.ComponentModel.DataAnnotations;
using System;

namespace ConsoleApp1
{
    public class Autor
    {
        public int autorId { get; set; }
        public string autorName { get; set; }
        public string originalName { get; set; }
        public DateTime birth { get; set; }
        public DateTime death { get; set; }
    }
}
