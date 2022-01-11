using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _065_Manan.Models
{
    public class order
    {
        [Key]
        [Required]
        public int Productid { get; set; }
        [Required]
        [Display(Name = "Product Name IS Must ")]
        [StringLength(30, MinimumLength = 10)]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Quantity is Must")]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = " Product Price is Must")]
        public decimal Productprice { get; set; }
        [StringLength(200, MinimumLength = 10)]
        public string Description { get; set; }

    }
}
