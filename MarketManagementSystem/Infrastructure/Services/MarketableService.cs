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

        public MarketableService()
        {
            _products = new List<Product>();

            _products.Add(new Product
            {

                Name = "iPhone Xs 256GB silver",
                Price = 2099.99,
                Category = Category.Telephone,
                Quantity = 1,
                Code = "151515"
            });
            _products.Add(new Product
            {
                Name = "HP ProBook 450 G6 (6MQ72EA)",
                Price = 1569.99,
                Category = Category.Noutbook,
                Quantity = 1,
                Code = "252525"
            });
            _products.Add(new Product
            {
                Name = "Canon Pixma GM2040",
                Price = 339.99,
                Category = Category.Printer,
                Quantity = 2,
                Code = "353535"
            });

            _sales=new List<Sale>()
            {
                new Sale
                {
                Number=1500,
                Amount=55600,
                Date=new DateTime(2020,10,20)
                }
               
            };

        }
    
        
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public List<Product> ShowAllList() {

        return _products;


        }
        public void AddSale(Sale sale)
        {
            _sales.Add(sale);
        }

        public List<Product> CancelProductFromSale(string productCode)
        {
            return _products.FindAll(p => p.Code == productCode).ToList();
        }

        public void FindNameNumberAmountCategoryOfTheProduct(string name, int quantity, double price, Category category, string code)
        {
            throw new NotImplementedException();
        }

        public void GetProductsByCategory(Category category)
        {
          List<Product> list= _products.FindAll(p => p.Category == category).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("{0),{1},{2},{3}",item.Code,item.Name,item.Price,item.Quantity);
            }
            
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

        public void RemoveProduct(string code)
        {
            var resultList = _products.ToList();
            var RemoveToItem = resultList.Find(p => p.Code == code);
            _products.Remove(RemoveToItem);


        }
    }
}
