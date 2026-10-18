using System;
using System.Collections.Generic;
using System.Text;

namespace EF_project2
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateOnly Date { get; set; }
        public Store? store { get; set; }
        public Customer? customer { get; set; }
        public Prodacts prodacts { get; set; }
    }
}
