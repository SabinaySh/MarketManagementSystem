using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Models
{
   public class SaleItem
    {
        public int Number { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}
