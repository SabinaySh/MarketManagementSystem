using System;
using System.Text;
using System.Collections.Generic;
using ConsoleTables;
using MarketManagementSystem.Infrastructure.Services;
using MarketManagementSystem.Infrastructure.Models;
using MarketManagementSystem.Infrastructure.Enums;
using System.Linq;

namespace MarketManagementSystem
{
    class Program
    {
        private static readonly MarketableService _marketableService = new MarketableService();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            int selectInt;
            do
            {
                #region First List

                Console.WriteLine("============================== Satış Ve Məhsulların Idare Edilməsi ==============================");
                Console.WriteLine("");
                Console.WriteLine("1.Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("2.Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("0.Sistemdən çıxmaq");

                #endregion

                #region List Selection

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Seçiminizi daxil edin: ");
                string selectInput = Console.ReadLine();

                while (!int.TryParse(selectInput, out selectInt))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Rəqəm daxil etməlisiniz");
                    selectInput = Console.ReadLine();
                }

                #endregion

                #region List Selection Switch

                switch (selectInt)
                {

                    case 0:
                        continue;

                    case 1:
                        ShowProductCategories();
                        break;

                    case 2:
                        ShowSaleCategories();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz, 0-2 aralığında seçim etməlisiniz");
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                }

                #endregion


            } while (selectInt == 0);


        }

        #region Show Categories

        static void ShowProductCategories()
        {
            int selectInt;
            do
            {
                #region Second List

                Console.WriteLine("");
                Console.WriteLine("------------------------- Məhsulların Siyahısı -------------------------");
                Console.WriteLine("");
                Console.WriteLine("1.Yeni məhsul əlavə etmək");
                Console.WriteLine("2.Məhsul üzərində düzəliş etmək");
                Console.WriteLine("3.Məhsulu silmək");
                Console.WriteLine("4.Bütün məhsulları göstərmək");
                Console.WriteLine("5.Kategoriyasına görə məhsulları göstərmək");
                Console.WriteLine("6.Qiymət aralığına görə məhsulları göstərmək");
                Console.WriteLine("7.Məhsullar arasında ada görə axtarış etmək");

                #endregion

                #region Second List Selection

                Console.WriteLine("");
                Console.WriteLine("Seçiminizi daxil edin: ");
                Console.WriteLine("");
                string selectInput = Console.ReadLine();

                while (!int.TryParse(selectInput, out selectInt))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz");
                    selectInput = Console.ReadLine();
                }

                #endregion

                #region Second List Switch

                switch (selectInt)
                {
                    case 1:
                        ShowAddProduct();
                        break;

                    case 2:
                        ShowEditProduct();
                        break;

                    case 3:
                        ShowRemoveProduct();
                        break;

                    case 4:
                        ShowListProduct();
                        break;

                    case 5:
                        ShowProductsByCategory();
                        break;

                    case 6:
                        ShowProductsByPrice();
                        break;

                    case 7:
                        ShowSearchByProduct();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine(" Siz yanlış seçim etdiniz, 1-7 aralığında seçim etməlisiniz");
                        Console.WriteLine("-----------------------------------------------------------");
                        break;
                }

                #endregion
            } while (selectInt != 0 );

        }
        static void ShowSaleCategories()
        {
            int selectInt;
            do
            {
                #region Third List

                Console.WriteLine("");
                Console.WriteLine("------------------------- Satışların Siyahısı -------------------------");
                Console.WriteLine("1.Yeni satış əlavə etmək");
                Console.WriteLine("2.Satışdakı məhsulu geri qaytarmaq");
                Console.WriteLine("3.Satışı silmək ");
                Console.WriteLine("4.Bütün satışları görmək");
                Console.WriteLine("5.Tarix aralığına görə satışları görmək");
                Console.WriteLine("6.Məbləq aralığına görə satışları görmək");
                Console.WriteLine("7.Tarixə görə satışları görmək");
                Console.WriteLine("8.Nömrəyə görə satışları görmək");

                #endregion

                #region Third List Selection

                Console.WriteLine("");
                Console.WriteLine("Seçiminizi daxil edin: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Reqem daxil etmelisiniz!");
                    select = Console.ReadLine();
                }

                #endregion

                #region Third List Switch

                switch (selectInt)
                {
                   case 1:
                        ShowAddSale();
                        break;

                    case 2:
                        ShowRemoveSoldProduct();
                        break;

                    case 3:
                        ShowRemoveSale();
                        break;

                    case 4:
                        ShowListSale();

                        break;

                    case 5:
                        SalesByDateRange();                     
                        break;

                    case 6:
                        ShowSalesByAmountRange();
                        break;

                    case 7:
                        ShowSalesByDate();
                        break;

                    case 8:
                        ShowSalesByNumber();
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine(" Siz yalnış seçim etdiniz, 1-8 aralığında seçim etməlisiniz");
                        Console.WriteLine("-----------------------------------------------------------");
                        break;
                }

                #endregion



            } while (selectInt != 0);

        }

        #endregion

        #region Show Product Methods

        static void ShowAddProduct()
        {

            Product product = new Product();

            Console.WriteLine("");
            Console.WriteLine("----------------- Məhsul əlavə et ------------------");
            Console.WriteLine("");

            int selectInt;
            do
            {
                #region Product Category List

                Console.WriteLine("Kateqoriya daxil edin: ");
                Console.WriteLine("1. Telephone");
                Console.WriteLine("2. Noutbook");
                Console.WriteLine("3. Printer");

                #endregion

                #region Product Category Selection

                Console.WriteLine("");
                Console.WriteLine("Seçiminizi daxil edin: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("Rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }

                #endregion



                switch (selectInt)
                {
                    case 1:
                        product.Category = Category.Telephone;
                        break;
                    case 2:
                        product.Category = Category.Noutbook;
                        break;
                    case 3:
                        product.Category = Category.Printer;
                        break;

                    default:
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Siz yalnış seçim etdiniz,1-3 aralığında seçim etməlisiniz");
                        Console.WriteLine("---------------------------------------------------------");
                        break;
                }
            } while (selectInt == 0 );


            Console.WriteLine("");
            Console.WriteLine("Məhsulun adını daxil edin: ");

            product.Name = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Məhsulun məbləğini daxil edin: ");
            string proPriceInput = Console.ReadLine();
            double ProPrice;

            while (!double.TryParse(proPriceInput, out ProPrice))
            {
                Console.WriteLine("");
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                proPriceInput = Console.ReadLine();
            }
            product.Price = ProPrice;
            Console.WriteLine("");

            Console.WriteLine("Məhsulun miqdarını daxil edin: ");
            string proQuantityInput = Console.ReadLine();
            int proQuantity;

            while (!int.TryParse(proQuantityInput, out proQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                proQuantityInput = Console.ReadLine();
            }

            product.Quantity = proQuantity;

            Console.WriteLine("");
            Console.WriteLine("Məhsulun kodunu daxil edin: ");
            product.Code = Console.ReadLine();

            if (product != null)
            {
                _marketableService.AddProduct(product);
            }

            Console.WriteLine("");
            Console.WriteLine("----------------- Məhsul əlavə edildi -----------------");
            Console.WriteLine("");
        }

        static void ShowEditProduct()
        {
            Product product = new Product();

            Console.WriteLine("------------------- Məhsul üzərində düzəliş etmək-------------------");
            Console.WriteLine("");

            Console.WriteLine("Məhsulun kodunu daxil edin: ");
            string code = Console.ReadLine();

            if (code == product.Code)
            {

                Console.WriteLine("");
                Console.WriteLine("Məhsulun adını daxil edin: ");
                string proName = Console.ReadLine();


                Console.WriteLine("");
                Console.WriteLine("Məhsulun sayını daxil edin");
                int proQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Məhsulun qiymətini daxil edin");
                double proPrice = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("");
                int selectInt;

                Console.WriteLine("Məhsulun kateqoriyasını daxil edin: ");
                Console.WriteLine("0.Telephone");
                Console.WriteLine("1.Noutbook");
                Console.WriteLine("2.Printer");

                Console.WriteLine("");
                Console.WriteLine("Seçiminizi daxil edin: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Rəqəm daxil etməlisiniz");
                    select = Console.ReadLine();
                }

                switch (selectInt)
                {
                    case 0:
                        product.Category = Category.Telephone;
                        break;

                    case 1:
                        product.Category = Category.Noutbook;
                        break;

                    case 2:
                        product.Category = Category.Printer;
                        break;
                    default:
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Siz yanlış seçim etmisiniz,0-2 aralığında seçim etməlisiniz");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                }

                List<Product> pro = _marketableService.EditProduct(code);

                foreach (var item in pro)
                {
                    item.Name = proName;
                    item.Price = proPrice;
                    item.Quantity = proQuantity;
                    item.Category = (Category)selectInt;

                }

                Console.WriteLine("");
                Console.WriteLine("------------------- Məhsul üzərində düzəliş edildi-------------------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız koda uyğun mehsul tapılmadı");
            }
        }

        static void ShowRemoveProduct()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------------------- Məhsulu ləğv etmek ---------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("Silmək istədiyiniz məhsulun kodunu daxil edin: ");

            string code = Console.ReadLine();

            if (code == product.Code)
            {

                _marketableService.RemoveProduct(code);

                Console.WriteLine("");
                Console.WriteLine("-------------------- Məhsul ləğv edildi ---------------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız koda uyğun məhsul tapılmadı");
            }
        }

        static void ShowListProduct()
        {
            Console.WriteLine("");
            Console.WriteLine("==================== Mövcud Məhsullar====================");
            Console.WriteLine("");

            var table = new ConsoleTable("No", "Adı", "Kateqoriyası", "Sayı", "Məbləği", "Kodu");
            int i = 1;
            foreach (var item in _marketableService.Products)
            {
                table.AddRow(i, item.Name, item.Category, item.Quantity, item.Price, item.Code);
                i++;
            }

            table.Write();

        }

        static void ShowProductsByCategory()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Kateqoriyasına görə məhsulları göstər --------");
            Console.WriteLine("=======================================================");

            int selectInt;


            Console.WriteLine("Məhsulun kateqoriyasını daxil edin: ");
            Console.WriteLine("0.Telephone");
            Console.WriteLine("1.Noutbook");
            Console.WriteLine("2.Printer");

            Console.WriteLine("");
            Console.WriteLine("Seçiminizi daxil edin: ");
            string select = Console.ReadLine();
            Console.WriteLine("");

            while (!int.TryParse(select, out selectInt))
            {
                
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                select = Console.ReadLine();
            }

            switch (selectInt)
            {
                case 0:
                    product.Category = Category.Telephone;
                    break;

                case 1:
                    product.Category = Category.Noutbook;
                    break;

                case 2:
                    product.Category = Category.Printer;
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Siz yanlış  seçim etmisiniz,0-2 aralığında seçim etməlisiniz");

                    Console.WriteLine("");
                    ShowProductsByCategory();
                    break;
            }


            _marketableService.GetProductsByCategory((Category)selectInt);
            Console.WriteLine("");
            Console.WriteLine("-------- Kateqoriyasına görə məhsullar göstərildi --------");


        }
        static void ShowProductsByPrice()
        {
            Product product = new Product();

            Console.WriteLine("");
            Console.WriteLine("-------- Məbləq aralığına görə məhsulları göstər --------");
            Console.WriteLine("");

            Console.Write("Minimum məbləği daxil edin: ");
            string minPriceInput = Console.ReadLine();
            double minPrice;

            while (!double.TryParse(minPriceInput, out minPrice))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                minPriceInput = Console.ReadLine();
            }

            Console.Write("Maksimum məbləği daxil edin: ");
            string maxPriceInput = Console.ReadLine();
            double maxPrice;

            while (!double.TryParse(maxPriceInput, out maxPrice))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                maxPriceInput = Console.ReadLine();
            }

            if (maxPrice > minPrice)
            {

                List<Product> price = _marketableService.GetProductsByRangePrice(minPrice, maxPrice);
                foreach (var item in price)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Kateqoriyası: " + item.Category + " Adı: " + item.Name + " Sayı: " + item.Quantity + " Məbləği: " + item.Price.ToString("#.##") + " Kodu: " + item.Code);
                }

                Console.WriteLine("");
                Console.WriteLine("-------- Məbləq aralığına görə məhsullar göstərildi --------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Maksimum məbləq minumum məbləqdən böyük olmalıdır");
            }

        }
        static void ShowSearchByProduct()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Məhsullar arasında ada görə axtarış et --------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");

            Console.WriteLine("Axtarış edəcəyiniz adı daxil edin: ");
            Console.WriteLine("");

            string searchNameInput = Console.ReadLine();

            if (searchNameInput == product.Name)
            {

                List<Product> searchName = _marketableService.GetProductsSearchByName(searchNameInput);
                foreach (var item in searchName)
                {
                    if (searchName != null)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Adı: " + item.Name + "Məbləği: " + item.Price + "Kateqoriyasi: " + item.Category + "Miqdarı: " + item.Quantity + "Kodu: " + item.Code);         //exception
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("-------- Məhsullar arasında ada görə axtarış edildi --------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız ada uyğun satış tapılmadı");
            }
        }

        #endregion

        #region Show Sale Methods
        
        static void ShowAddSale()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------------------- Satış əlavə etmək ----------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");


            Console.Write("Mehsulun kodunu daxil edin: ");
            Console.WriteLine("");

            string proCodeInput = Console.ReadLine();

            
            Console.Write("Mehsulun miqdarını daxil edin :");
            Console.WriteLine("");

            string proQuantityInput = Console.ReadLine();
            int proQuantity;

            while (!int.TryParse(proQuantityInput, out proQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                proQuantityInput = Console.ReadLine();
            }

            _marketableService.AddSale(proCodeInput, proQuantity);

            Console.WriteLine("");
            Console.WriteLine("----------------- Satış əlavə edildi -----------------");

        }

        static void ShowRemoveSoldProduct()
        {
            Sale sale = new Sale();

            Console.WriteLine("");
            Console.WriteLine("------------ Satışdan məhsulun çıxarılması ------------");
            Console.WriteLine("");
            Console.WriteLine("Geri qaytarmaq istədiyiniz satış nömrəsini daxil edin: ");
            Console.WriteLine("");

            string saleNumInput = Console.ReadLine();
            int saleNum;

            while(!int.TryParse(saleNumInput, out saleNum))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                saleNumInput = Console.ReadLine();
            }

            Console.WriteLine("Geri qaytarmaq istədiyiniz məhsulun kodunu daxil edin: ");
            Console.WriteLine("");

            string proCodeInput = Console.ReadLine();
          
            Console.WriteLine("Geri qaytarmaq istədiyiniz məhsulun sayını daxil edin: ");
            string proQuantityInput = Console.ReadLine();
            int proQuantity;

            while(!int.TryParse(proQuantityInput, out proQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                proQuantityInput = Console.ReadLine();


                _marketableService.RemoveSoldProduct(saleNum, proCodeInput, proQuantity);
            }

            Console.WriteLine("");
            Console.WriteLine("------------ Satışdan məhsul çıxarıldı ------------");

        }

        static void ShowRemoveSale()
        {
            Sale sale = new Sale();
            Console.WriteLine("=======================================================");
            Console.WriteLine("-------------------- Satışları ləğv etmek ----------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("Silmək istədiyiniz satışın nömrəsini daxil edin: ");

            int numInput = Convert.ToInt32(Console.ReadLine());

            if (numInput == sale.Number)
            {

                _marketableService.RemoveSalesByNumber(numInput);

                Console.WriteLine("");
                Console.WriteLine("-------------------- Satış ləğv edildi ----------------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız nömrəyə uyğun satış tapılmadı");
            }

        }

        static void ShowListSale()
        {
            Console.WriteLine("");
            Console.WriteLine("==================== Mövcud Satışlar ====================");
            Console.WriteLine("");

            var table = new ConsoleTable("No", "Nömrə", "Məbləq", "Məhsul sayı", "Tarix");
            int i = 1;

            int itemCount = _marketableService.saleItems.Select(c => c.Quantity).FirstOrDefault();


            foreach (var item in _marketableService.Sales)
            {
                table.AddRow(i, item.Number, item.Amount.ToString("#.##"),itemCount, item.Date.ToString("dd.MM.yyyy"));
                i++;
            }

            table.Write();

        }

        static void SalesByDateRange()
        {
            Sale sale = new Sale();

            Console.WriteLine("==============================================================");
            Console.WriteLine("-------- Tarix aralığına görə satışların göstərilməsi --------");
            Console.WriteLine("===============================================================");

            Console.Write("Başlanğıc tarixi daxil edin(gün.ay.il): ");
            string startDateInput = Console.ReadLine();
            DateTime startDate;

            while (!DateTime.TryParse(startDateInput, out startDate))
            {
                Console.WriteLine("gün.ay.il şəklində daxil etməlisiniz ");
                startDateInput = Console.ReadLine();
            }

            Console.Write("Son tarixi daxil edin(gün.ay.il): ");
            string endDateInput = Console.ReadLine();
            DateTime endDate;

            while (!DateTime.TryParse(endDateInput, out endDate))
            {
                Console.WriteLine("gün.ay.il şəklində daxil etməlisiniz ");
                endDateInput = Console.ReadLine();
            }

            if (endDate > startDate)
            {

                List<Sale> resultDate = _marketableService.GetSalesByDateRange(startDate, endDate);
                foreach (var item in resultDate)
                {
                    if (resultDate.Count != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nomrəsi: " + item.Number + " Məbləği: " + item.Amount.ToString("#.##") + " Satış miqdarı: " + item.saleItems.Count + " Tarixi:" + item.Date.ToString("dd.MM.yyyy"));
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("-------- Tarix aralığına görə satışlar göstərildi --------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Son tarix başlanğıc tarixden böyuk olmalıdır");
            }

        }

        static void ShowSalesByAmountRange()
        {
            Sale sale = new Sale();

            Console.WriteLine("===============================================================");
            Console.WriteLine("-------- Məbləq aralığına görə satışların göstərilməsi --------");
            Console.WriteLine("===============================================================");
             
            Console.Write("Minimum məbləği daxil edin: ");
            string minAmountInput = Console.ReadLine();
            double minAmount;

            while (!double.TryParse(minAmountInput, out minAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                minAmountInput = Console.ReadLine();
            }

            Console.Write("Maksimum məbləği daxil edin: ");
            string maxAmountInput = Console.ReadLine();
            double maxAmount;

            while (!double.TryParse(maxAmountInput, out maxAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                maxAmountInput = Console.ReadLine();
            }

            if (minAmount < maxAmount)
            {

                List<Sale> amount = _marketableService.GetSalesByRangeAmount(minAmount, maxAmount);
                foreach (var item in amount)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nomrəsi: " + item.Number + " Məbləği: " + item.Amount.ToString("#.##") + " Satış miqdarı:" + item.saleItems.Count + " Tarixi: " + item.Date.ToString("dd.MM.yyyy"));
                }

                Console.WriteLine("");
                Console.WriteLine("-------- Məbləq aralığına görə satışlar göstərildi --------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Maksimum məbləq minumum məbləqdən böyük olmalıdır");
            }
        }
        static void ShowSalesByDate()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Tarixə görə satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");

            Console.Write("Tarixi daxil edin(gün.ay.il): ");
            string DateInput = Console.ReadLine();
            DateTime Date;

            while (!DateTime.TryParse(DateInput, out Date))
            {
                Console.WriteLine("gün.ay.il şəklində daxil etməlisiniz! ");
                DateInput = Console.ReadLine();
            }

            if (Date == sale.Date)
            {

                List<Sale> date = _marketableService.GetSalesByDate(Date);
                foreach (var item in date)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Nomrəsi: " + item.Number + " Məbləği:" + item.Amount.ToString("#.##") + " Satış miqdarı: " + item.saleItems.Count + " Tarixi: " + item.Date.ToString("dd.MM.yyyy"));

                }
                Console.WriteLine("");
                Console.WriteLine("-------- Tarixə görə satışlar göstərildi --------");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız tarixə uyğun satış tapılmadı");
            }

        }

        static void ShowSalesByNumber()
        {
            Sale sale = new Sale();

            Console.WriteLine("");
            Console.WriteLine("---------  Satış məlumatlarının göstərilməsi ---------");
            Console.WriteLine("");
            Console.WriteLine("Satış nömrəsini daxil edin: ");
            Console.WriteLine("");

            string saleNumInput = Console.ReadLine();
            int saleNum;

            
            while (!int.TryParse(saleNumInput, out saleNum))
            {
               
                Console.Write("Rəqəm daxil etməlisiniz ");
                Console.WriteLine("");
                saleNumInput = Console.ReadLine();
            }

            if (saleNum == sale.Number)
            {

                List<Sale> number = _marketableService.GetSalesByNumber(saleNum);

                foreach (var item in number)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Satış Nömrəsi: " + item.Number + "Satış Məbləği: " + item.Amount.ToString("#.##") + "Məhsulun Sayı: " + item.saleItems.Count + "Tarixi:" + item.Date.ToString("dd.MM.yyyy"));
                }

                var saleItem = _marketableService.GetSaleItem(saleNum);


                foreach (var item in saleItem)
                {
                    Console.WriteLine("Sayı: " + item.Quantity + "Satış Nömrəsi: " + item.Number + "Məhsulun Adı: " + item.Product.Name);
                }
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Yazdığınız nomreye uyğun satış tapılmadı");
            }
        }

    }
}
#endregion











