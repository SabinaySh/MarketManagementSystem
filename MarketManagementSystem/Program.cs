using MarketManagementSystem.Infrastructure.Services;
using System;
using System.Text;

namespace MarketManagementSystem
{
    class Program
    {
        private static readonly MarketableService _marketableService = new MarketableService();
        static void Main(string[] args)
        {
            int selectInt;
            do
            {
                Console.WriteLine("============Satish ve mehsullarin idare edilmesi============");

                Console.WriteLine("1.Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2.Satishlar uzerinde emeliyyat aparmaq");
                Console.WriteLine("0.Sistemden cixmaq");
                Console.WriteLine("==================");
                Console.WriteLine("Seciminizi daxil edin");

                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
                    select = Console.ReadLine();
                }

                switch (selectInt)
                {
                    case 0:
                        continue;

                    case 1:
                        ShowProductMenu();
                        break;

                    case 2:
                        ShowSaleMenu();
                        break;
                    default:
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("0-2 arasinda sec");
                        break;

                }


            } while (selectInt != 0);

        }
        static void ShowProductMenu()
        {
            int selectInt1;
            do
            {
                Console.WriteLine("1.Yeni mehsul elave et ");
                Console.WriteLine("2.Mehsul uzerinde duzelis et ");
                Console.WriteLine("3. Mehsulu sil ");
                Console.WriteLine("4.Butun mehsullari goster ");
                Console.WriteLine("5.Categoriyasina gore mehsullari goster ");
                Console.WriteLine("6.Qiymet araligina gore mehsullari goster ");
                Console.WriteLine("7. Mehsullar arasinda ada gore axtaris et");
                Console.WriteLine("0.Esas sehifeye qayit ");

                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt1))
                {
                    Console.WriteLine("reqem daxil etmelisiniz");
                    select = Console.ReadLine();
                }

                switch (selectInt1)
                {
                    case 0:
                        continue;

                    case 1:
                        Console.WriteLine("Add Product");
                        break;

                    case 2:
                        Console.WriteLine("Edit Product");
                        break;

                    case 3:
                        Console.WriteLine("Remove Product");
                        break;

                    case 4:
                        Console.WriteLine("List Product");
                        break;

                    case 5:
                        Console.WriteLine("List Product by category name");
                        break;

                    case 6:
                        Console.WriteLine("List Product by amount range");
                        break;

                    case 7:
                        Console.WriteLine("Search by Product name");
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("0-7 arasinda secim");
                        Console.WriteLine("---------------------");
                        break;
                }



            } while (selectInt1 != 0);
        }
        static void ShowSaleMenu()
        {
            int selectInt2;
            do
            {
                Console.WriteLine("1.Yeni satis elave et ");
                Console.WriteLine("2.Satisdaki hansisa mehsulun geri qaytarilmasi (satisdan cixarilmasi) ");
                Console.WriteLine("3. satisin silinmesi ");
                Console.WriteLine("4.Butun satislarin ekrana cixarilmasi  ");
                Console.WriteLine("5.verilen tarix araligina gore satislarin gosterilmesi ");
                Console.WriteLine("6.verilen mebleg araligina gore satislarin gosterilmesi ");
                Console.WriteLine("7.verilmis bir tarixde olan satislarin  gosterilmesi");
                Console.WriteLine("8.Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi ");
                Console.WriteLine("0.Esas sehifeye qayit ");

                string select = Console.ReadLine();
                while (!int.TryParse(select, out selectInt2))
                {
                    Console.WriteLine("reqem daxil etmelisiniz");
                    select = Console.ReadLine();
                }

                switch (selectInt2)
                {
                    case 0:
                        continue;

                    case 1:
                        Console.WriteLine("Add Sale");
                        break;

                    case 2:
                        Console.WriteLine("Get product by sale");
                        break;

                    case 3:
                        Console.WriteLine("Remove sale");
                        break;

                    case 4:
                        Console.WriteLine("List sale");
                        break;

                    case 5:
                        Console.WriteLine("sale by date range");
                        break;

                    case 6:
                        Console.WriteLine("sale by amount range");
                        break;

                    case 7:
                        Console.WriteLine("sale by date");
                        break;
                    case 8:
                        Console.WriteLine("search by product name");
                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("0-7 arasinda secim");
                        Console.WriteLine("---------------------");
                        break;
                }
            } while (selectInt2 != 0);
        }


    }   }

 
     

    

