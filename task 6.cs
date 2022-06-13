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
            int picturesCount=52;
            int picturesInRow = 3;
            int fullRowsCount = picturesCount / picturesInRow;
            int picturesLeft = picturesCount % picturesInRow;

            Console.WriteLine("Полностью заполненных рядов: {0} Осталось картинок: {1}", fullRowsCount , picturesLeft);
        }
    }
}
