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
            string userName = "Иванов";
            string userSurname = "Олег";

            Console.WriteLine("Имя: "+userName+ "\n" + "Фамилия: " + userSurname);

            string temporaryVariable = userName;
            userName = userSurname;
            userSurname = temporaryVariable;

            Console.WriteLine("Имя: " + userName + "\n" + "Фамилия: " + userSurname);

            Console.ReadKey();
        }
    }
}
