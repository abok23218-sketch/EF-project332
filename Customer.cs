using System;
using System.Collections.Generic;
using System.Text;

namespace EF_project2
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; } = string.Empty;
        public string?CreaditCardNum { get; set; }
       
    }
}
