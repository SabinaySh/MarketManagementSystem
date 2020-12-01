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
        #region Private List

        private List<Sale> _sales;
        public List<Sale> Sales => _sales;

        private List<Product> _products;
        public List<Product> Products => _products;
        private List<SaleItem> _saleItems;
        public List<SaleItem> saleItems => _saleItems;

        #endregion

        #region Constructor
        public MarketableService()
        {
            _products = new List<Product>();



            _products.Add(new Product
            {

                Name = "iPhone Xs 256GB silver",
                Price = 2099.99,
                Category = Category.Telephone,
                Quantity = 10,
                Code = "151515"
            });

            _products.Add(new Product
            {
                Name = "iPhone 11 256GB silver",
                Price = 3000.99,
                Category = Category.Telephone,
                Quantity = 5,
                Code = "555555"
            });
               


            _products.Add(new Product
            {
                Name = "HP ProBook 450 G6 (6MQ72EA)",
                Price = 1569.99,
                Category = Category.Noutbook,
                Quantity = 5,
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

            _saleItems = new List<SaleItem>();

            _saleItems.Add(new SaleItem
            {
                Number = 1,
                Product = _products.Find(p => p.Code == "151515"),
                Quantity = 1,
            });


            _sales = new List<Sale>();

            _sales.Add(new Sale
            {
                Number = 1,
                Amount = 2000.99,
                Date = new DateTime(2020,07,07),
                saleItems = _saleItems.FindAll(s => s.Number == 1)
            });
           

        }

        #endregion

        #region Methods Of The Product


        //Add a new product
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        //Return of the product from sale
        public List<Product> EditProduct(string productCode)
        {
            return _products.FindAll(p => p.Code == productCode).ToList();
        }

        //Delete of the product from sale
        public void RemoveProduct(string code)
        {
            var resultList = _products.ToList();
            var RemoveToItem = resultList.Find(p => p.Code == code);
            _products.Remove(RemoveToItem);

        }

        //Show products by category
        public void GetProductsByCategory(Category category)
        {
            var list = _products.FindAll(p => p.Category == category);

            foreach (var item in list)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Price:  " + item.Price);
                Console.WriteLine("Quantity: " + item.Quantity);
                Console.WriteLine("Code:  " + item.Code);
                Console.WriteLine("");

            }

        }

        //Show products by price range
        public List<Product> GetProductsByRangePrice(double startPrice, double endPrice)
        {
            return _products.Where(s => s.Price >= startPrice && s.Price <= endPrice).ToList();
        }

        //Search by product by name
        public List<Product> GetProductsSearchByName(string name)
        {
            var list = _products.FindAll(s => s.Name.Contains(name)).ToList();

            foreach (var item in list)
            {
                Console.WriteLine("");
                Console.WriteLine("Adi: " + item.Name);
                Console.WriteLine("Qiymeti: " + item.Price);
                Console.WriteLine("Kategoriyasi: " + item.Category);
                Console.WriteLine("Sayi: " + item.Quantity);
                Console.WriteLine("Kodu: " + item.Code);
                Console.WriteLine("");

            }

            return list;
        }

        #endregion

        #region Methods Of The Sale


        //Add new sales
        public void AddSale(string productCode,int productQuantity)
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            double amount = 0;

            var product = _products.Where(p => p.Code == productCode).FirstOrDefault();
            var Code = productCode;

            var saleItem = new SaleItem();
            saleItem.Number = saleItems.Count + 1;
            saleItem.Product = product;
            saleItem.Quantity = productQuantity;
            saleItems.Add(saleItem);

            amount += productQuantity * saleItem.Product.Price;

            var saleNumber = _sales.Count + 1;
            var saleDate = DateTime.Now;

            var sale = new Sale();

            sale.Number = saleNumber;
            sale.Amount = amount;
            sale.Date = saleDate;
            _sales.Add(sale);


        }

        //Return of product on sale 
        public double RemoveSoldProduct(int saleNumber, string productCode, int productQuantity)
        {
            double amount = 0;

            var productList = _products.ToList();
            var saleList = _sales.ToList();

            var sale = saleList.Find(s => s.Number == saleNumber);

            bool findProduct = productList.Exists(f => f.Code == productCode);

            if (findProduct == true)
            {

                var List = productList.Find(p => p.Code == productCode);
                if(sale.Amount>List.Price * productQuantity)
                {
                    sale.Amount -= List.Price * productQuantity;
                }

                else if(sale.Amount==List.Price * productQuantity)
                {
                    _sales.Remove(sale);
                }
            }
            return amount;
        }

        //Delete sale by number
        public void RemoveSalesByNumber(int number)
        {
            var resultList = _sales;
            var RemoveToItem = resultList.Find(p => p.Number == number);
            _sales.Remove(RemoveToItem);
        }

        //Show sales by date range
        public List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate)
        {
            return _sales.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();
        }

        //Show sales by amount range
        public List<Sale> GetSalesByRangeAmount(double startAmount, double endAmount)
        {
            return _sales.Where(s => s.Amount >= startAmount && s.Amount <= endAmount).ToList();
        }

        //Show sales by date
        public List<Sale> GetSalesByDate(DateTime date)
        {
            return _sales.Where(s => s.Date == date).ToList();
        }

        //Show sales by number
        public List<Sale> GetSalesByNumber(int number)
        {
            return _sales.Where(s => s.Number == number).ToList();
        }

        //Show sale of the quantity by sales number
        public List<SaleItem> GetSaleItem(int saleNumber)
        {
            return _sales.Find(s => s.Number == saleNumber).saleItems.ToList();
        }

        #endregion


    }
}
