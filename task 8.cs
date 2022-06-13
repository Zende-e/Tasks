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
            Console.Write("Сколько человек в очереди: ");
            int queueLeight = Convert.ToInt32(Console.ReadLine());
            int timeForOnePerson = 10;
            int hours = timeForOnePerson * queueLeight / 60;
            int minutes = timeForOnePerson * queueLeight % 60;

            Console.WriteLine("Вы должны стоять в очереди {0} часов {1} минут", hours, minutes);
            Console.ReadKey();
        }
    }
}
