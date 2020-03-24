using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Boolean_02
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

            Console.WriteLine("\n\n\n\n\tBoolean 02");
            Console.WriteLine(
@"
***************************************************************************************************

        Boolean2–. Дано целое число A. Проверить истинность высказывания: 
«Число A является нечетным».

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
