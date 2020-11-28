using System;
using System.Text;
using System.Collections.Generic;
using ConsoleTables;
using MarketManagementSystem.Infrastructure.Services;
using MarketManagementSystem.Infrastructure.Models;
using MarketManagementSystem.Infrastructure.Enums;


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

                Console.WriteLine("============================== Satish Ve Mehsullarin Idare Edilmesi ==============================");
                Console.WriteLine("");
                Console.WriteLine("1.Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2.Satishlar uzerinde emeliyyat aparmaq");
                Console.WriteLine("0.Sistemden cixmaq");

                #endregion

                #region List Selection

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Seciminizi daxil edin: ");
                string selectInput = Console.ReadLine();

                while (!int.TryParse(selectInput, out selectInt))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
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
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Siz yanlis secim etdiniz, 0-2 araliginda seciminizi etmelisiniz");
                        Console.WriteLine("-------------------------------------------------------------------");
                        break;
                }

                #endregion


            } while (selectInt != 0);


        }

        #region Show Categories

        static void ShowProductCategories()
        {
            int selectInt;
            do
            {
                #region Second List

                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1.Yeni mehsul elave etmek");
                Console.WriteLine("2.Mehsul uzerinde duzelis etmek");
                Console.WriteLine("3.Mehsulu silmek");
                Console.WriteLine("4.Butun mehsullari gostermek");
                Console.WriteLine("5.Kateqoriyasina gore mehsullari gostermek");
                Console.WriteLine("6.Qiymet araligina gore mehsullari gostermek");
                Console.WriteLine("7.Mehsullar arasinda ada gore axtaris etmek");

                #endregion

                #region Second List Selection

                Console.WriteLine("");
                Console.WriteLine("Seciminizi daxil edin: ");
                Console.WriteLine("");
                string selectInput = Console.ReadLine();

                while (!int.TryParse(selectInput, out selectInt))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
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
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine(" Siz yanlish reqem daxil etdiniz, 1-7 araliginda reqem daxil etmelisiniz");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        break;
                }

                #endregion
            } while (selectInt != 0);

        }
        static void ShowSaleCategories()
        {
            int selectInt;
            do
            {
                #region Third List

                Console.WriteLine("");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1.Yeni satis elave etmek");
                Console.WriteLine("2.Satisdan mehsulu geri qaytarmaq");
                Console.WriteLine("3.Satisi silmek ");
                Console.WriteLine("4.Butun satislari gormek");
                Console.WriteLine("5.Tarix araligina gore satislari gormek");
                Console.WriteLine("6.Mebleg araligina gore satislari gormek");
                Console.WriteLine("7.Tarixe gore satislari gormek");
                Console.WriteLine("8.Nomreye gore satislari gormek");

                #endregion

                #region Third List Selection

                Console.WriteLine("");
                Console.WriteLine("Seciminizi daxil edin: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {

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
                        Console.WriteLine("------------------------------------------------------------------------------");
                        Console.WriteLine(" Siz yanlis secim etdiniz, 1-8 araliginda seciminizi etmelisiniz");
                        Console.WriteLine("------------------------------------------------------------------------------");
                        break;
                }

                #endregion



            } while (selectInt != 0);

        }

        #endregion

        #region Show Product Methods

        static void ShowAddProduct()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("----------------- Məhsul əlavə et ------------------");
            Console.WriteLine("====================================================");

            Product product = new Product();

            
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
                Console.WriteLine("Seciminizi daxil edin: ");
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
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Siz yanlis seçim etdiniz, 1-3 arasında seçiminizi etməlisiniz");
                        Console.WriteLine("----------------------------------------------");
                        break;
                }
            } while (selectInt == 0);


            Console.WriteLine("");
            Console.WriteLine("Məhsulun adını daxil edin: ");

            product.Name = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Məhsulun məbləgini daxil edin: ");
            string productPriceInput = Console.ReadLine();
            double ProductPrice;

            while (!double.TryParse(productPriceInput, out ProductPrice))
            {
                Console.WriteLine("");
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                productPriceInput = Console.ReadLine();
            }
            product.Price = ProductPrice;
            Console.WriteLine("");

            Console.WriteLine("Məhsulun miqdarını daxil edin: ");
            string productQuantityInput = Console.ReadLine();
            int productQuantity;

            while (!int.TryParse(productQuantityInput, out productQuantity))
            {
                Console.WriteLine("Reqem daxil etmelisiniz!");
                productQuantityInput = Console.ReadLine();
            }

            product.Quantity = productQuantity;

            Console.WriteLine("");
            Console.WriteLine("Məhsulun kodunu daxil edin: ");
            product.Code = Console.ReadLine();

            if (product != null)
            {
                _marketableService.AddProduct(product);
            }

            Console.WriteLine("=======================================================");
            Console.WriteLine("----------------- Mehsul elave edildi -----------------");
            Console.WriteLine("=======================================================");
        }

        static void ShowEditProduct()
        {
            Product product = new Product();

            Console.WriteLine("====================================================================");
            Console.WriteLine("------------------- Mehsul uzerinde duzelis etmek-------------------");
            Console.WriteLine("====================================================================");

            Console.WriteLine("Mehsulun kodunu daxil edin: ");
            string code = Console.ReadLine();

            List<Product> product1 = _marketableService.CancelProductFromSale(code);


            Console.WriteLine("");
            Console.WriteLine("Mehsulun adini daxil edin: ");
            string productName = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("Mehsulun sayini daxil edin");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Mehsulun qiymetini daxil edin");
            double productPrice = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("");

            int selectInt;
            do
            {

                Console.WriteLine("Mehsulun kateqoriyasini daxil edin: ");
                Console.WriteLine("0.Telephone");
                Console.WriteLine("1.Noutbook");
                Console.WriteLine("2.Printer");

                Console.WriteLine("");
                Console.WriteLine("Seciminizi daxil edin: ");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Reqem daxil etmelisiniz!");
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
                        Console.WriteLine("Siz yanlis secim etmisiniz,0-2 araliginda secim etmelisiniz!");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                }
            } while (selectInt == -1);

            foreach (var item in product1)
            {
                item.Name = productName;
                item.Quantity = productQuantity;
                item.Price = productPrice;
                item.Category = (Category)selectInt;

            }
        }

        static void ShowRemoveProduct()
        {
            Product product = new Product();
            Console.WriteLine("=======================================================");
            Console.WriteLine("---------------------Məhsulu ləğv etmek----------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Silmek istediyinizi mehsulun kodunu daxil edin: ");

            string code = Console.ReadLine();
            _marketableService.RemoveProduct(code);


            if (product != null)
            {
                Console.WriteLine("\n -------Satis silindi--------");
            }
            else
            {
                Console.WriteLine("Bos ola bilmez");
            }
        }

        static void ShowListProduct()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("--------------------- MOVCUD Mehsullar ----------------");
            Console.WriteLine("=======================================================");

            var table = new ConsoleTable("No", "Adi", "Kateqoriyasi", "Sayı", "Qiyməti", "Kodu");
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
            Console.WriteLine("-------- Kateqoriyasina gore mehsullari goster --------");
            Console.WriteLine("=======================================================");

            int selectInt;


            Console.WriteLine("Mehsulun kateqoriyasini daxil edin: ");
            Console.WriteLine("0.Telephone");
            Console.WriteLine("1.Noutbook");
            Console.WriteLine("2.Printer");

            Console.WriteLine("");
            Console.WriteLine("Seciminizi daxil edin: ");
            string select = Console.ReadLine();
            Console.WriteLine("");

            while (!int.TryParse(select, out selectInt))
            {
                Console.WriteLine("");
                Console.WriteLine("Reqem daxil etmelisiniz!");
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
                    Console.WriteLine("Siz yanlis secim etmisiniz,0-2 araliginda secim etmelisiniz!");

                    Console.WriteLine("------------------------------------------------------------");
                    ShowProductsByCategory();
                    break;
            }


            _marketableService.GetProductsByCategory((Category)selectInt);


        }
        static void ShowProductsByPrice()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Mebleg araligina gore mehsullari goster --------");
            Console.WriteLine("=======================================================");

            Console.Write("Minimum meblegi daxil edin: ");
            string minPriceInput = Console.ReadLine();
            double minPrice;

            while (!double.TryParse(minPriceInput, out minPrice))
            {
                Console.WriteLine("Reqem daxil etmelisiniz: ");
                minPriceInput = Console.ReadLine();
            }

            Console.Write("Maksimum meblegi daxil edin: ");
            string makPriceInput = Console.ReadLine();
            double makPrice;

            while (!double.TryParse(makPriceInput, out makPrice))
            {
                Console.WriteLine("Reqem daxil etmelisiniz: ");
                makPriceInput = Console.ReadLine();
            }

            List<Product> result = _marketableService.GetProductsByRangePrice(minPrice, makPrice);
            foreach (var item in result)
            {
                    Console.WriteLine("");
                    Console.WriteLine("Kateqoriyasi: " + item.Category + " Adi: " + item.Name + " Sayi: " + item.Quantity + " Meblegi: " + item.Price.ToString("#.##") + " Kodu: " + item.Code);
             }
        }
        static void ShowSearchByProduct()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Mehsullar arasinda ada gore axtaris et --------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");

            Console.WriteLine("Axtaris edeceyiniz adi daxil edin: ");
            Console.WriteLine("");

            string search = Console.ReadLine();

            List<Product> products= _marketableService.GetProductsSearchByName(search);
            foreach (var item in products)
            {
                if (products != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine(item.Name + " " + item.Price + " " + item.Category + " " + item.Quantity + " " + item.Code);         //exception
                }
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
            Console.Write("Satışın nömrəsini daxil edin: ");
            Console.WriteLine("");

            string saleNumberInput = Console.ReadLine();
            int SaleNumber;

            while (!int.TryParse(saleNumberInput, out SaleNumber))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                saleNumberInput = Console.ReadLine();
            }

            sale.Number = SaleNumber;
          
           
            Console.Write("Satışın məbləgini daxil edin :");
            Console.WriteLine("");
            string saleAmountInput = Console.ReadLine();
            double saleAmount;

            while (!double.TryParse(saleAmountInput, out saleAmount))
            {
                
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                Console.WriteLine("");
                saleAmountInput = Console.ReadLine();
            }

            sale.Amount = saleAmount;
          
           
            Console.Write("Tarixi daxil edin (gün.ay.il): ");
            Console.WriteLine("");
            string saleDateInput = Console.ReadLine();
            DateTime saleDate;

            while (!DateTime.TryParse(saleDateInput, out saleDate))
            {
                
                Console.WriteLine("Tarixi daxil etməlisiniz!");
                Console.WriteLine("");
                saleDateInput = Console.ReadLine();
            }

            sale.Date = saleDate;

           
            SaleItem saleItems = new SaleItem();

            Console.Write("Məhsulun nömrəsini daxil edin :");
            Console.WriteLine("");
            string saleİtemNumberInput = Console.ReadLine();
            int saleİtemNumber;

            while (!int.TryParse(saleİtemNumberInput, out saleİtemNumber))
            {
             
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                Console.WriteLine("");
                saleİtemNumberInput = Console.ReadLine();
            }

            saleItems.Number = saleİtemNumber;
           


            Console.Write("Məhsulun sayini daxil edin: ");
            Console.WriteLine("");
            string saleİtemQuantityInput = Console.ReadLine();
            int saleİtemQuantity;

            while (!int.TryParse(saleİtemQuantityInput, out saleİtemQuantity))
            {
              
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
                Console.WriteLine("");
                saleİtemQuantityInput = Console.ReadLine();
            }

            saleItems.Quantity = saleİtemQuantity;
          
            Product product = new Product();

            
            Console.Write("Məhsulun kodunu daxil edin: ");
            Console.WriteLine("");
            string productCodeInput = Console.ReadLine();

            product.Code = productCodeInput;
            

            //if (sale == null)
            //{
                _marketableService.AddSale(SaleNumber, saleİtemQuantity);
            //}

            Console.WriteLine("");
            Console.WriteLine("----------------- Satış əlavə edildi -----------------");

        }

        static void ShowRemoveSoldProduct()
        {
            //Sale sale = new Sale();

            //Console.WriteLine("=======================================================");
            //Console.WriteLine("------------ Satışdan məhsulun cıxarılması ------------");
            //Console.WriteLine("=======================================================");
            //Console.WriteLine("Geri qaytarmaq istədiyiniz məhsulun satış nömrəsini daxil edin: ");
            //Console.WriteLine("");

            //int saleNumberInput = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Silmek istədiyiniz məhsulun kodunu daxil edin: ");
            //Console.WriteLine("");
            //string productCodeInput = Console.ReadLine();

            //Console.WriteLine("Silmək istədiyiniz məhsulun sayını daxil edin: ");
            //Console.WriteLine("");
            //int productQuantityInput = Convert.ToInt32(Console.ReadLine());



            //    Console.WriteLine("\nCixarilacaq satishin nomresini daxil edin :");
            //    string saleNumberInput = Console.ReadLine();
            //    int saleNumber;

            //    while (!int.TryParse(saleNumberInput, out saleNumber))
            //    {
            //        Console.WriteLine("Reqem daxil etmelisiniz!");
            //        saleNumberInput = Console.ReadLine();
            //    }
            //    #endregion

            //    #region Product Code
            //    Console.WriteLine("\nCixarilacaq satishin mehsul kodunu daxil edin:");
            //    string productCodeInput = Console.ReadLine();
            //    try
            //    {
            //        _marketableService.RemoveProduct(productCodeInput);

            //        #region Quantity
            //        Console.WriteLine("Satishin sayini daxil edin :");
            //        string saleQuantityInput = Console.ReadLine();
            //        int saleQuantity;

            //        while (!int.TryParse(saleQuantityInput, out saleQuantity))
            //        {
            //            Console.WriteLine("Reqem daxil etmelisiniz!");
            //            saleQuantityInput = Console.ReadLine();
            //        }
            //        #endregion

            //        #region Result
            //        try
            //        {
            //            _marketableService.RemoveSoldProduct(number, productCode, quantity);
            //            Console.WriteLine("-------------- Mehsul ugurla satishdan legv edildi --------------");
            //        }
            //        catch (ProductQuantityExceededException e)
            //        {
            //            Console.WriteLine("Bu satishda secdiyiniz mehsulun bu qeder sayi yoxdur !");
            //        }
            //        #endregion

            //    }
            //    catch (ProductNotFoundException e)
            //    {
            //        Console.WriteLine("Bu kodda satish yoxdur !");
            //    }


            //}



        }

        static void ShowRemoveSale()
        {
            Sale sale = new Sale();
            Console.WriteLine("=======================================================");
            Console.WriteLine("-------------------- Satışları ləğv etmek ----------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("Silmek istədiyiniz satışın nömrəsini daxil edin: ");

            int numberInput = Convert.ToInt32(Console.ReadLine());
            _marketableService.RemoveSalesByNumber(numberInput);
            //EXCEPTION
        }

        static void ShowListSale()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("--------------------- MOVCUD SATISLAR ----------------");
            Console.WriteLine("=======================================================");

            var table = new ConsoleTable("No", "Nomre", "Qiymet", "Mehsul sayi", "Tarix");
            int i = 1;
            foreach (var item in _marketableService.Sales)
            {
                table.AddRow(i, item.Number, item.Amount.ToString("#.##"), item.saleItems.Count, item.Date.ToString("dd.MM.yyyy"));
                i++;
            }

            table.Write();

        }

        static void SalesByDateRange()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Tarix aralıgına görə satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");

            Console.Write("Başlangıc tarixi daxil edin(Gun.ay.il): ");
            string startDateInput = Console.ReadLine();
            DateTime startDate;

            while (!DateTime.TryParse(startDateInput, out startDate))
            {
                Console.WriteLine("Gun.ay.il şəklində daxil etməlisiniz! ");
                startDateInput = Console.ReadLine();
            }

            Console.Write("Son tarixi daxil edin(Gun.ay.il): ");
            string endDateInput = Console.ReadLine();
            DateTime endDate;

            while (!DateTime.TryParse(endDateInput, out endDate))
            {
                Console.WriteLine("Gun.ay.il şəklində daxil etməlisiniz! ");
                endDateInput = Console.ReadLine();
            }

            List<Sale> resultDate = _marketableService.GetSalesByDateRange(startDate, endDate);
            foreach (var item in resultDate)
            {
                if (resultDate.Count != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Number:" + item.Number + " Amount:" + item.Amount.ToString("#.##") + " SaleItems:" + item.saleItems.Count + " Date:" + item.Date.ToString("dd.MM.yyyy"));
                }
            }
        }

        static void ShowSalesByAmountRange()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Məbləg araligina görə satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");
             
            Console.Write("Başlangıc məbləgi daxil edin: ");
            string startAmountInput = Console.ReadLine();
            double startAmount;

            while (!double.TryParse(startAmountInput, out startAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                startAmountInput = Console.ReadLine();
            }

            Console.Write("Son məbləgi daxil edin: ");
            string endAmountInput = Console.ReadLine();
            double endAmount;

            while (!double.TryParse(endAmountInput, out endAmount))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                endAmountInput = Console.ReadLine();
            }

            List<Sale> resultAmount = _marketableService.GetSalesByRangeAmount(startAmount, endAmount);
            foreach (var item in resultAmount)
            {
                if (resultAmount.Count != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Number:" + item.Number + " Amount:" + item.Amount + " SaleItems:" + item.saleItems.Count + " Date:" + item.Date.ToString("dd.MM.yyyy"));
                }
            }
            //exception
        }
        static void ShowSalesByDate()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Tarixə görə Satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");

            Console.Write("Tarixi daxil edin(Gun.Ay.Il): ");
            string DateInput = Console.ReadLine();
            DateTime Date;

            while (!DateTime.TryParse(DateInput, out Date))
            {
                Console.WriteLine("Gun.ay.il şəklində daxil etməlisiniz! ");
                DateInput = Console.ReadLine();
            }

            List<Sale> resultDate = _marketableService.GetSalesByDate(Date);
            foreach (var item in resultDate)
            {
                
                    Console.WriteLine("");
                    Console.WriteLine("Number:" + item.Number + " Amount:" + item.Amount.ToString("#.##") + " SaleItems:" + item.saleItems.Count + " Date:" + item.Date.ToString("dd.MM.yyyy"));
                
            }
        }

        static void ShowSalesByNumber()
        {
            Sale sale = new Sale();
            Console.WriteLine("=======================================================");
            Console.WriteLine("---------  Satış məlumatlarının göstərilməsi ---------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");
            Console.WriteLine("Satışın nömrəsini daxil edin: ");
            Console.WriteLine("");

            string saleNumberInput = Console.ReadLine();
            int saleNumber;

            
            while (!int.TryParse(saleNumberInput, out saleNumber))
            {
               
                Console.Write("Rəqəm daxil etməlisiniz!: ");
                Console.WriteLine("");
                saleNumberInput = Console.ReadLine();
            }

            List<Sale> numbers = _marketableService.GetSalesByNumber(saleNumber);

            foreach (var item in numbers)
            {
                Console.WriteLine("");
                Console.WriteLine("Satış Nömrəsi: " + item.Number + "\n" + "Satışın Məbləgi: " + item.Amount.ToString("#.##") + "\n" + "Məhsulun Sayı: " + item.saleItems.Count + "\n" + "Tarixi:" + item.Date.ToString("dd.MM.yyyy"));
            }

            var saleItem = _marketableService.ShowSaleItem(saleNumber);


            foreach (var item in saleItem)
            {
                Console.WriteLine("Sayı: " + item.Number + "\n" + "İtem Nömrəsi: " + item.Number + "\n" + "Məhsulun Adı: " /*+ item.SaleProduct.ProductName*/);
            }
        }

    }

       
    }
#endregion











