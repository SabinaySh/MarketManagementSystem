using MarketManagementSystem.Infrastructure.Enums;
using MarketManagementSystem.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketManagementSystem.Infrastructure.Interfaces
{
   public interface IMarketable
    {

        #region Sale

        List<Sale> Sales { get; }
        void AddSale(string productCode, int productQuantity);

        double RemoveSoldProduct(int saleNumber,string productCode,int productQuantity);
        void RemoveSalesByNumber(int number);
        List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
        List<Sale> GetSalesByDate(DateTime date);
        List<Sale> GetSalesByRangeAmount(double startAmount, double endAmount);
        List<Sale> GetSalesByNumber(int number);
        
        

        #endregion

        #region Product

        List<Product> Products { get; }
        void AddProduct(Product product);
        List<Product> CancelProductFromSale(string productCode);
        void RemoveProduct(string code);
        void GetProductsByCategory(Category category);
        List<Product> GetProductsByRangePrice(double startPrice, double endPrice);
        List<Product> GetProductsSearchByName(string name);
        
        
        #endregion

    }
}
