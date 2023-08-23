using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sumScores = 0;

            Console.WriteLine("Добро пожаловать в игру 21! Пожалуйста, введите количества ваших карт: ");

            byte sumCards = byte.Parse(Console.ReadLine());

            for (int i = 0; i < sumCards; i++)
            {
                Console.WriteLine($"Введите значение {i+1}-ой карты: ");
                string valueCard = Console.ReadLine();
                switch (valueCard)
                {
                    case "2":
                        sumScores += 2;
                        break;
                    case "3":
                        sumScores += 3;
                        break;
                    case "4":
                        sumScores += 4;
                        break;
                    case "5":
                        sumScores += 5;
                        break;
                    case "6":
                        sumScores += 6;
                        break;
                    case "7":
                        sumScores += 7;
                        break;
                    case "8":
                        sumScores += 8;
                        break;
                    case "9":
                        sumScores += 9;
                        break;
                    case "10":
                    case "J":
                    case "j":
                    case "Q":
                    case "q":
                    case "K":
                    case "k":
                    case "T":
                    case "t":
                        sumScores += 10;
                        break;
                    default:
                        Console.WriteLine("Введены некорректные данные, попробуйте снова!");
                        i--;
                        break;
                }
            }

            Console.WriteLine($"Ваше количество очков: {sumScores}");
            Console.WriteLine(sumScores > 21 ? "Вы перебрали" : sumScores < 21 ? "Вы выиграли" : "Вы набрали 21!");
            Console.ReadKey();
        }
    }
}
