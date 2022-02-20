using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3L21PracaDomowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj swoje imię:");
                var name = Console.ReadLine();

                Console.WriteLine("Podaj miejsce urodzenia:");
                var location = Console.ReadLine();

                Console.WriteLine("Podaj datę urodzenia:");
                var birthDate = DateTime.Parse(Console.ReadLine());


                var age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.DayOfYear < birthDate.DayOfYear) age--;

                Console.WriteLine($"Witaj {name}! Twoim miejscem urodzenia jest {location} i masz {age} lat.");

            }
            catch (Exception)
            {

                Console.WriteLine("Podano nieprawidłową wartość!");
            }
        }
    }
}
