using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3L22PrzykladoweRozwiazanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Imię: ");
            var name = Console.ReadLine();

            Console.Write("Rok urodzenia: ");
            var yearOfBirth = GetYear();

            Console.Write("Miesiąc urodzenia: ");
            var monthOfBirth = GetMonth();

            Console.Write("Dzień urodzenia: ");
            var dayOfBirth = GetDay(yearOfBirth, monthOfBirth);

            var dateofBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            var age = DateTime.Now.Year - yearOfBirth;

            Console.Write("Miejsce urodzenia: ");
            var city = Console.ReadLine();

            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
            {
                age--;
            }
            Console.WriteLine($"Cześć {name} urodziłeś się w {city} i masz {age} lat.");
            Console.ReadKey();


        }

        private static int GetDay(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth) || day < 1)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz");
                    continue;
                }
                return day;
            }
        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz");
                    continue;
                }
                return month;
            }
        }

        private static int GetYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz");
                    continue;
                }

                return year;

            }
        }
    }
}
