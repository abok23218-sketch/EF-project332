using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EF_project2.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; } = string.Empty;
        public string?CreaditCardNum { get; set; }
       
    }
}
