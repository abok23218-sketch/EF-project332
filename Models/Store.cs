using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_project2.Models
{
    internal class Store
    {
        public int StoreId { get; set; }
        [Required]
        [MaxLength(80)]
        public string? Name { get; set; }
      
      


    }
}
