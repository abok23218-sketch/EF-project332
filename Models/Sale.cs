using System;
using System.Collections.Generic;
using System.Text;

namespace EF_project2.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int StoreId { get; set; }
        public Store? store { get; set; }
        public int CustomerId { get; set; }
        public Customer? customer { get; set; }
        public int ProdactsId { get; set; }
        public Prodacts prodacts { get; set; }

    }
}
