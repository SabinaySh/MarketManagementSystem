using MarketManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Interfaces
{
   public class IMarketable
    {
        List<Sale> Sales { get; }
        List<Product> Product { get; }
        void AddSale(Dictionary<string, int> ProductFromSale);
        void RemoveSaleByIndex(int index);
        void RemoveTotalSaleByIndex(int index);
        List<Sale> Date(DateTime startDate, DateTime endDate);
        List<Sale> Date(DateTime date);
        List<Sale> Amount(double startAmount, double endAmount);
        void AddProduct();
        List<Product> Category(Enums.Category category);
        List<Product> Price(double startPrice, double endPrice);
        List<Product> Search(Product Name);

    }
}
