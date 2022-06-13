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
            Console.WriteLine("Как вас зовут");
            string userName = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string userAge = Console.ReadLine();
            Console.WriteLine("Укажите свой знак зодиака");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine("Вас зовут " + userName + ", вам " + userAge + " год, " + " по знаку зодиака вы " + zodiacSign);
            Console.ReadKey();
        }
    }
}
