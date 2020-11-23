using MarketManagementSystem.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Models
{
   public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
        public int Code { get; set; }
    }
}
