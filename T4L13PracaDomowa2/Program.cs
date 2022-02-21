using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4L13PracaDomowa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Podaj liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz.");
                }

                Console.WriteLine(Game(number));
                Console.WriteLine("Jeśli chcesz wyjść z gry, naciśnij ESC.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        private static string Game(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
