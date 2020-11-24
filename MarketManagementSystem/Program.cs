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
                Console.WriteLine("3.Sistemden cixmaq");

                Console.WriteLine("Seciminizi edin");
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
                        Console.WriteLine("mehsullar uzerinde emeliyyat aparmaq");
                        break;
                    case 2:
                        Console.WriteLine("satislar uzerinde emeliyyat aparmaq");
                        break;
                    default:
                        Console.WriteLine("----------------------");
                        Console.WriteLine("siz yanlish secim etdiniz,0-2 araliginda secim etmelisiniz!");
                        Console.WriteLine("-----------------");
                        break;
                }

            } while (selectInt!=0);
        }
     }
}
    

