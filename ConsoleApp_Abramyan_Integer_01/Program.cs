using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Integer_01
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

            Console.WriteLine("\n\n\n\n\tInteger 01");
            Console.WriteLine(
@"
***************************************************************************************************

        Integer1–. Дано расстояние L в сантиметрах. Используя операцию деления
нацело, найти количество полных метров в нем (1 метр = 100 см).

***************************************************************************************************");

            Console.Write("Input distance in centimeter : ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Distance in metr = " + (int)(a/100));

            Console.ForegroundColor = tmp_color;

            Console.WriteLine("\n\n\tEXIT\t");
            Console.ReadKey();
            return;
        }
    }
}
