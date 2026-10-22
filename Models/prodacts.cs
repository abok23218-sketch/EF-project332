using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_project2.Models
{
    internal class Prodacts
    {
        public int ProdactsId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        [MaxLength(250)]
        public string Description { get; set; } = "No description";
    }
}
