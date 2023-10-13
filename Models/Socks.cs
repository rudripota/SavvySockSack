using System;
using System.ComponentModel.DataAnnotations;

namespace SavvySockSack.Models
{
    public class Socks
    {
        public int Id { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        [Required] 
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required] 
        public string Size { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string Material { get; set; }

        [StringLength(50, MinimumLength = 5), Required]
        public string Pattern { get; set; }
        
        [Required]
        public double Price { get; set; }
        
        [RegularExpression(@"^(0(\.[0-9]+)?|5(\.0+)?)$"), Required]
        
        public double Rating { get; set; }
    }
}
