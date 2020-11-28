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
            Console.WriteLine("Məhsulun məbləğini daxil edin: ");
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
                Console.WriteLine("Rəqəm daxil etməlisiniz!");
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
            Console.WriteLine("----------------- Məhsul əlavə edildi -----------------");
            Console.WriteLine("=======================================================");
        }

        static void ShowEditProduct()
        {
            Product product = new Product();

            Console.WriteLine("====================================================================");
            Console.WriteLine("------------------- Məhsul uzərində duzəliş etmək-------------------");
            Console.WriteLine("====================================================================");

            Console.WriteLine("Məhsulun kodunu daxil edin: ");
            string code = Console.ReadLine();

            List<Product> product1 = _marketableService.CancelProductFromSale(code);


            Console.WriteLine("");
            Console.WriteLine("Məhsulun adini daxil edin: ");
            string productName = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("Məhsulun sayini daxil edin");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Məhsulun qiymətini daxil edin");
            double productPrice = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("");
            int selectInt;
           
                Console.WriteLine("Məhsulun kateqoriyasini daxil edin: ");
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
                        Console.WriteLine("Siz yanlış seçim etmisiniz,0-2 aralığında seçim etməlisiniz!");
                        Console.WriteLine("------------------------------------------------------------");
                        break;
                }
           

            foreach (var item in product1)
            {
                item.Name = productName;
                item.Price = productPrice;
                item.Quantity = productQuantity;
                item.Category = (Category)selectInt;

            }

            Console.WriteLine("");
            Console.WriteLine("------------------- Məhsul uzərində duzəliş edildi-------------------");
            
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
            _marketableService.RemoveProduct(code);

            Console.WriteLine("");
            Console.WriteLine("-------------------- Məhsul ləğv edildi ---------------");
        }

        static void ShowListProduct()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("--------------------- MOVCUD Məhsullar ----------------");
            Console.WriteLine("=======================================================");

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
            Console.WriteLine("-------- Kateqoriyasına gorə məhsulları gostər --------");
            Console.WriteLine("=======================================================");

            int selectInt;


            Console.WriteLine("Məhsulun kateqoriyasını daxil edin: ");
            Console.WriteLine("0.Telephone");
            Console.WriteLine("1.Noutbook");
            Console.WriteLine("2.Printer");

            Console.WriteLine("");
            Console.WriteLine("Seciminizi daxil edin: ");
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
                    Console.WriteLine("Siz yanlıs secim etmisiniz,0-2 aralıgında secim etməlisiniz");

                    Console.WriteLine("");
                    ShowProductsByCategory();
                    break;
            }


            _marketableService.GetProductsByCategory((Category)selectInt);
            Console.WriteLine("");
            Console.WriteLine("-------- Kateqoriyasına gorə məhsullar gostərildi --------");


        }
        static void ShowProductsByPrice()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Məbləğ aralığına gorə məhsulları gostər --------");
            Console.WriteLine("=======================================================");

            Console.Write("Minimum ği daxil edin: ");
            string minPriceInput = Console.ReadLine();
            double minPrice;

            while (!double.TryParse(minPriceInput, out minPrice))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                minPriceInput = Console.ReadLine();
            }

            Console.Write("Maksimum məbləği daxil edin: ");
            string makPriceInput = Console.ReadLine();
            double makPrice;

            while (!double.TryParse(makPriceInput, out makPrice))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz: ");
                makPriceInput = Console.ReadLine();
            }

            List<Product> price = _marketableService.GetProductsByRangePrice(minPrice, makPrice);
            foreach (var item in price)
            {
                    Console.WriteLine("");
                    Console.WriteLine("Kateqoriyası: " + item.Category + " Adı: " + item.Name + " Sayı: " + item.Quantity + " Məbləği: " + item.Price.ToString("#.##") + " Kodu: " + item.Code);
             }

            Console.WriteLine("");
            Console.WriteLine("-------- Məbləğ aralığına gorə məhsullar gostərildi --------");

        }
        static void ShowSearchByProduct()
        {
            Product product = new Product();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Məhsullar arasında ada gorə axtarış et --------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");

            Console.WriteLine("Axtarış edəcəyiniz adı daxil edin: ");
            Console.WriteLine("");

            string searchNameInput = Console.ReadLine();

            List<Product> searchName= _marketableService.GetProductsSearchByName(searchNameInput);
            foreach (var item in searchName)
            {
                if (searchName != null)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Adı: " + item.Name + "Məbləği: " + item.Price + "Kateqoriyasi: " + item.Category + "Miqdarı: " + item.Quantity + "Kodu: " + item.Code);         //exception
                }
            }
            Console.WriteLine("");
            Console.WriteLine("-------- Məhsullar arasında ada gorə axtarış edildi --------");
        }

        #endregion

        #region Show Sale Methods
        
        //satish siyahisina yeni satish elave edir.
        static void ShowAddSale()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------------------- Satış əlavə etmək ----------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("");


            Console.Write("Mehsulun kodunu daxil edin: ");
            Console.WriteLine("");

            string productCodeInput = Console.ReadLine();

            
            Console.Write("Mehsulun miqdarini daxil edin :");
            Console.WriteLine("");

            string productQuantityInput = Console.ReadLine();
            int productQuantity;

            while (!int.TryParse(productQuantityInput, out productQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                productQuantityInput = Console.ReadLine();
            }

            _marketableService.AddSale(productCodeInput, productQuantity);

            Console.WriteLine("");
            Console.WriteLine("----------------- Satış əlavə edildi -----------------");

        }

        //satisdan mehsulu legv edir.
        static void ShowRemoveSoldProduct()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("------------ Satışdan məhsulun cıxarılması ------------");
            Console.WriteLine("=======================================================");
            Console.WriteLine("Geri qaytarmaq istədiyiniz satış nömrəsini daxil edin: ");
            Console.WriteLine("");

            string saleNumberInput = Console.ReadLine();
            int saleNumber;

            while(!int.TryParse(saleNumberInput,out saleNumber))
            {
                Console.WriteLine("Reqem daxil etmelisiniz");
                Console.WriteLine("");
                saleNumberInput = Console.ReadLine();
            }

            Console.WriteLine("Geri qaytarmaq istədiyiniz satışın məhsul kodunu daxil edin: ");
            Console.WriteLine("");

            string productCodeInput = Console.ReadLine();
            //_marketableService.RemoveSalesByNumber(productCodeInput);

            Console.WriteLine("Geri qaytarmaq istədiyiniz satışın sayını daxil edin: ");
            string saleQuantityInput = Console.ReadLine();
            int saleQuantity;

            while(!int.TryParse(saleQuantityInput,out saleQuantity))
            {
                Console.WriteLine("Rəqəm daxil etməlisiniz");
                Console.WriteLine("");
                saleQuantityInput = Console.ReadLine();


                _marketableService.RemoveSoldProduct(saleNumber, productCodeInput, saleQuantity);
            }

            Console.WriteLine("------------ Satışdan məhsul cıxarıldı ------------");

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

            Console.WriteLine("");
            Console.WriteLine("-------------------- Satış ləğv edildi ----------------");

            //EXCEPTION
        }

        static void ShowListSale()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("--------------------- MOVCUD SATISLAR ----------------");
            Console.WriteLine("=======================================================");

            var table = new ConsoleTable("No", "Nomrə", "Məbləq", "Məhsul sayı", "Tarix");
            int i = 1;

            var itemCount = _marketableService.saleItems.Select(c => c.Quantity).FirstOrDefault();


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

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Tarix aralığına görə satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");

            Console.Write("Başlanğıc tarixi daxil edin(gun.ay.il): ");
            string startDateInput = Console.ReadLine();
            DateTime startDate;

            while (!DateTime.TryParse(startDateInput, out startDate))
            {
                Console.WriteLine("gun.ay.il şəklində daxil etməlisiniz ");
                startDateInput = Console.ReadLine();
            }

            Console.Write("Son tarixi daxil edin(gun.ay.il): ");
            string endDateInput = Console.ReadLine();
            DateTime endDate;

            while (!DateTime.TryParse(endDateInput, out endDate))
            {
                Console.WriteLine("gun.ay.il şəklində daxil etməlisiniz ");
                endDateInput = Console.ReadLine();
            }

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

        static void ShowSalesByAmountRange()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Məbləq aralığına görə satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");
             
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

            List<Sale> resultAmount = _marketableService.GetSalesByRangeAmount(minAmount, maxAmount);
            foreach (var item in resultAmount)
            {
                if (resultAmount.Count != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nomrəsi: " + item.Number + " Məbləği: " + item.Amount.ToString("#.##") + " Satış miqdarı:" + item.saleItems.Count + " Tarixi: " + item.Date.ToString("dd.MM.yyyy"));
                }
            }
            //exception
            Console.WriteLine("");
            Console.WriteLine("-------- Məbləq aralığına görə satışlar göstərildi --------");


        }
        static void ShowSalesByDate()
        {
            Sale sale = new Sale();

            Console.WriteLine("=======================================================");
            Console.WriteLine("-------- Tarixə görə Satışların göstərilməsi --------");
            Console.WriteLine("=======================================================");

            Console.Write("Tarixi daxil edin(gun.ay.il): ");
            string DateInput = Console.ReadLine();
            DateTime Date;

            while (!DateTime.TryParse(DateInput, out Date))
            {
                Console.WriteLine("gun.ay.il şəklində daxil etməlisiniz! ");
                DateInput = Console.ReadLine();
            }

            List<Sale> resultDate = _marketableService.GetSalesByDate(Date);
            foreach (var item in resultDate)
            {
                
                    Console.WriteLine("");
                    Console.WriteLine("Nomrəsi: " + item.Number + " Məbləği:" + item.Amount.ToString("#.##") + " Satış miqdarı: " + item.saleItems.Count + " Tarixi: " + item.Date.ToString("dd.MM.yyyy"));
                
            }
            Console.WriteLine("");
            Console.WriteLine("-------- Tarixə görə Satışlar göstərildi --------");


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
                Console.WriteLine("Satış Nömrəsi: " + item.Number  + "Satış Məbləği: " + item.Amount.ToString("#.##") + "Məhsulun Sayı: " + item.saleItems.Count + "Tarixi:" + item.Date.ToString("dd.MM.yyyy"));
            }

            var saleItem = _marketableService.GetSaleItem(saleNumber);


            foreach (var item in saleItem)
            {
                Console.WriteLine("Sayı: " + item.Number + "Satış Nömrəsi: " + item.Number + "Məhsulun Adı: " /*+ item.SaleProduct.ProductName*/);
            }
        }

    }

       
    }
#endregion











