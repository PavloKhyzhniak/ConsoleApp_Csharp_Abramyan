using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Begin_20
{
    class Program
    {
        public static string title = "March 2020 - Abramyan M.E. Сборник задач по программированию(2007 год).";

        static private void input_point(out double x, out double y, params string[] str)
        {
            x = 0;y = 0;

            if (str.Length == 3)
            {
                ConsoleColor tmp_color = Console.ForegroundColor;

                Console.WriteLine(str[0]);

                Console.Write(str[1]);
                Console.ForegroundColor = ConsoleColor.Green;
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;

                Console.Write(str[2]);
                Console.ForegroundColor = ConsoleColor.Green;
                y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = title;

            Console.SetWindowSize(120, 30);

            ConsoleColor tmp_color = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\n\n\n\tBegin 20");
            Console.WriteLine(
@"
***************************************************************************************************

        Begin20–. Найти расстояние между двумя точками с заданными координатами
(x1, y1) и (x2, y2) на плоскости. Расстояние вычисляется по формуле
sqrt((x2 - x1)^2 + (y2 - y1)^2).

***************************************************************************************************");

            double x1, y1, x2 , y2;
            try
            {
                Console.WriteLine("Input point 1: ");

                Console.Write("x1 = ");
                Console.ForegroundColor = ConsoleColor.Green;
                x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;
                
                Console.Write("y1 = ");
                Console.ForegroundColor = ConsoleColor.Green;
                y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.ForegroundColor = tmp_color;

                input_point(out x2, out y2, "Input point 2: ", "x2 = ", "y2 = ");
            }
            catch
            {
                throw new Exception("Wrong input.");
            }

            checked
            {
                Console.WriteLine("Distance = " + Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)));
            }


            Console.ForegroundColor = tmp_color;

            Console.ReadKey();
            return;
        }
    }
}
