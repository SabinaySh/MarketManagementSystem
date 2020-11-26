using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Models
{
    public class Sale
    {
        public int Number { get; set; }
        public double Amount { get; set; }
       public List<SaleItem> saleItems { get; set; }
        public DateTime Date { get; set; }
    }
}
