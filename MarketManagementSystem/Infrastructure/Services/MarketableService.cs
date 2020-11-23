using MarketManagementSystem.Infrastructure.Enums;
using MarketManagementSystem.Infrastructure.Interfaces;
using MarketManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Services
{
    public class MarketableService : IMarketable
    {
        public List<Sale> Sales => throw new NotImplementedException();

        public List<Product> Products => throw new NotImplementedException();

        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public void AddSale(Dictionary<string, int> ProductFromSale)
        {
            throw new NotImplementedException();
        }

        public void CancelProductFromSale(int saleNumber, string productCode, int quantity)
        {
            throw new NotImplementedException();
        }

        public void FindNameNumberAmountCategoryOfTheProduct(string name, int quantity, double price, Category category, string code)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByRangePrice(double startPrice, double endPrice)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsSearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Sale GetSalesByNumber(int number)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByRangeAmount(double startAmount, double endAmount)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetTotalSales()
        {
            throw new NotImplementedException();
        }
    }
}
