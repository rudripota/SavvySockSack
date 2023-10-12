using System;
using System.ComponentModel.DataAnnotations;

namespace SavvySockSack.Models
{
    public class Socks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Pattern { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
    }
}
