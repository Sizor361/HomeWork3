using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальный диапазон - ");
            int maxRange = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();
            int hiddenNumber = randomNumber.Next(maxRange + 1);

            Console.WriteLine("Я загадал число, попробуй угадай!");

            while (true)
            {
                string exitGame = Console.ReadLine();

                if (exitGame == "")
                {
                    Console.WriteLine($"Было загадано {hiddenNumber} число! В следующий раз повезёт!");
                    break;
                }

                int userNumber = int.Parse(exitGame);

                if (userNumber > hiddenNumber)
                {
                    Console.WriteLine("Ваше число > загаданного. Попробуй ещё раз!");
                }
                else if (userNumber < hiddenNumber)
                {
                    Console.WriteLine("Ваше число < загаданного. Попробуй ещё раз!");
                }
                else
                {
                    Console.WriteLine("Вы угадали число! Поздравляем!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
