using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int couter = 2;
            bool simpleNumber = true;

            Console.WriteLine("Введите число:");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber > couter && simpleNumber)
            {
                if (userNumber % couter == 0) simpleNumber = false;
                couter++;
            }

            Console.WriteLine(simpleNumber == true ? "Число простое" : "Число не простое");
            Console.ReadKey();
        }
    }
}
