using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                var number1 = GetInput();

                Console.WriteLine("Operacja: (dozwolone: +, -, /, *)");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj drugą liczbę");
                var number2 = GetInput();

                var result = Calculate(number1, number2, action);

                Console.WriteLine($"wynik: {result}");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }

        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }

            return input;

        }

        private static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    {
                        return number1 + number2;
                    }
                case "-":
                    {
                        return number1 - number2;
                    }
                case "*":
                    {
                        return number1 * number2;
                    }
                case "/":
                    {
                        return number1 / number2;
                    }
                default:
                    throw new Exception("wybrałeś złą operację!");
            }

        }
    }
}
