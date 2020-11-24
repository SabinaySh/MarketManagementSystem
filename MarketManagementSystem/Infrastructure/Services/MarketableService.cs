using MarketManagementSystem.Infrastructure.Enums;
using MarketManagementSystem.Infrastructure.Interfaces;
using MarketManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Services
{
    public class MarketableService : IMarketable
    {
        private List<Sale> _sales;
        public List<Sale> Sales => _sales;

        private List<Product> _products;
        public List<Product> Products => _products;

        public void AddProduct(Product product)
        {
            _products.Add(product);
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
            return _products.Where(s => s.Category == category).ToList();
        }

        public List<Product> GetProductsByRangePrice(double startPrice, double endPrice)
        {
            return _products.Where(s => s.Price >= startPrice && s.Price <= endPrice).ToList();
        }

        public List<Product> GetProductsSearchByName(string name)
        {
            return _products.Where(s=>s.Name.Contains(name)).ToList();
        }

        public List<Sale> GetSalesByDate(DateTime date)
        {
            return _sales.Where(s => s.Date == date).ToList();
        }

        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            return _sales.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();
        }

        public Sale GetSalesByNumber(int number)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSalesByRangeAmount(double startAmount, double endAmount)
        {
            return _sales.Where(s => s.Amount >= startAmount && s.Amount <= endAmount).ToList();
        }

        public List<Sale> GetTotalSales()
        {
            throw new NotImplementedException();
        }
    }
}
