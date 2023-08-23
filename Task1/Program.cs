using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number % 2 == 0 ? "Чётное" : "Нечётное");

            Console.ReadKey();

        }
    }
}
