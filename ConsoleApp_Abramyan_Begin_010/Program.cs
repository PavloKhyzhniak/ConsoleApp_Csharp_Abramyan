using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Begin_01
{
    class Program
    {
        public static string title = "March 2020 - Abramyan M.E. Сборник задач по программированию(2007 год).";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = title;

            Console.SetWindowSize(120, 30);

            ConsoleColor tmp_color = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n\n\n\tBegin 10");
            Console.WriteLine(
@"
***************************************************************************************************

        Begin10–. Даны два ненулевых числа. Найти сумму, разность, произведение и
частное их квадратов.

***************************************************************************************************");

            Console.WriteLine("Input two non zero number: ");
            double number1, number2;
            try
            {
                Console.Write("number1 = ");
                Console.ForegroundColor = ConsoleColor.Green;
                number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;

                Console.Write("number2 = ");
                Console.ForegroundColor = ConsoleColor.Green;
                number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;
            }
            catch
            {
                throw new Exception("Wrong input.");
            }

            checked
            {
                Console.WriteLine("number1 + number2 = " + (number1 + number2));
                Console.WriteLine("number1 - number2 = " + (number1 - number2));
                Console.WriteLine("number1 * number2 = " + (number1 * number2));
                Console.WriteLine("number1 / number2 = " + (number1 / number2));

                Console.WriteLine();
                Console.WriteLine("number1^2 + number2^2 = " + (Math.Pow(number1,2) + Math.Pow(number2,2)));
                Console.WriteLine("number1^2 - number2^2 = " + (number1*number1 - number2*number2));
                Console.WriteLine("number1^2 * number2^2 = " + (number1*number1 * number2*number2));
                Console.WriteLine("number1^2 / number2^2 = " + (number1*number1 / number2*number2));
            }
            Console.ForegroundColor = tmp_color;

            Console.ReadKey();
            return;
        }
    }
}

