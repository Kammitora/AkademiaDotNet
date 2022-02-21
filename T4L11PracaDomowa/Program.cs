using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4L11PracaDomowa
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
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz");
                    continue;
                }

                Console.WriteLine(EvenOrOdd(number));
                Console.WriteLine("Aby zakończyć, wciśnij ESC.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        private static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Liczba parzysta" : "Liczba nieparzysta";
        }
    }
}