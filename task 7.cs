using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goldInBackPack;
            int crystalsToBuy;
            int crystalExchangeRate;
            int crystalsInBackPack = 0;

            Console.Write("Cколько у вас золота: ");
            goldInBackPack = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("Cколько кристалов купить: ");
                crystalsToBuy = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                crystalExchangeRate = random.Next(1, 100);
                Console.WriteLine("Курс кристала  {0} ", crystalExchangeRate);


                goldInBackPack -= crystalsToBuy * crystalExchangeRate;
                crystalsInBackPack += crystalsToBuy;

                Console.WriteLine("Кристалов в рюкзаке  {0} ", crystalsInBackPack);
                Console.WriteLine("Золота в Рюкзаке {0}", goldInBackPack);
            }
        }
    }
}
