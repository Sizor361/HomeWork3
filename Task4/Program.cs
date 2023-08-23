using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.MaxValue;
            int count = 1;

            Console.WriteLine("Введите длинну последовательности: ");

            int length = int.Parse(Console.ReadLine());

            if (length != 0)
            {
                do
                {
                    Console.WriteLine($"Введите значение {count++} числа: ");
                    int tempValue = int.Parse(Console.ReadLine());

                    if (tempValue < minValue)
                    {
                        minValue = tempValue;
                    }

                    length--;

                } while (length != 0);
            }

            Console.WriteLine($"Ваше минимальное число - {minValue}");
            Console.ReadKey();
        }
    }
}