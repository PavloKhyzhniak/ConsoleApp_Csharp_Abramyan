using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Begin_010
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
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n\n\n\tBegin 01");
            Console.WriteLine(
@"
***************************************************************************************************

        Begin1–. Дана сторона квадрата a. Найти его периметр P = 4*a.

***************************************************************************************************");

            Console.Write("Input side of kvadrat: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimeter = " + (4 * a));

            Console.ForegroundColor = tmp_color;

            Console.ReadKey();
            return;
        }
    }
}