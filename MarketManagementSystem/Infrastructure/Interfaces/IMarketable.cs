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
        void AddSale(Dictionary<string, int> ProductFromSale);
        void CancelProductFromSale(int saleNumber, string productCode, int quantity);
        List<Sale> GetTotalSales();
        List<Sale> GetSalesByDateRange(DateTime startDate, DateTime endDate);
        List<Sale> GetSalesByDate(DateTime date);
        List<Sale> GetSalesByRangeAmount(double startAmount, double endAmount);
        Sale GetSalesByNumber(int number);

        #endregion

        #region Product

        List<Product> Products { get; }
        void AddProduct(Product product);
        void FindNameNumberAmountCategoryOfTheProduct(string name, int quantity, double price, Category category, string code);
        List<Product> GetProductsByCategory(Category category);
        List<Product> GetProductsByRangePrice(double startPrice, double endPrice);
        List<Product> GetProductsSearchByName(string name);

        #endregion

    }
}
