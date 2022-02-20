using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3L23PracaDomowa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var correctValue = random.Next(0, 100);
            var numbnerOfTries = 0;
            while (true)
            {
                numbnerOfTries++;
                Console.WriteLine("Wybierz liczbę z zakresu 0-100: ");
                if (!int.TryParse(Console.ReadLine(), out int chosingNumber))
                {
                    Console.WriteLine("BŁĄD: niepoprawne dane. spróbuj jeszcze raz.");
                    continue;
                }
                else if (chosingNumber < 0 || chosingNumber > 100)
                {
                    Console.WriteLine("BŁĄD: Wybrana liczba jest spoza zakresu. spróbuj jeszcze raz.\n");
                    continue;
                }
                else if (chosingNumber > correctValue)
                {
                    Console.WriteLine("Za duża liczba. Spróbuj jeszcze raz.\n");
                    continue;
                }
                else if (chosingNumber < correctValue)
                {
                    Console.WriteLine("Za mała liczba. Spróbuj jeszcze raz.\n");
                    continue;
                }
                else
                {
                    Console.WriteLine($"HURRA! To prawidłowa liczba! Udało Ci się za {numbnerOfTries} razem\n");
                    return;
                }
            }

        }
    }
}
