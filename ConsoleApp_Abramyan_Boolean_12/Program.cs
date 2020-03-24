using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Boolean_12
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

            Console.WriteLine("\n\n\n\n\tBoolean 12");
            Console.WriteLine(
@"
***************************************************************************************************

        Boolean12–. Даны три целых числа: A, B, C. Проверить истинность высказывания: 
«Каждое из чисел A, B, C положительное».

***************************************************************************************************");

            int a,b,c;

            bool repeat = true;
            while (repeat)
            {

                Console.ForegroundColor = ConsoleColor.Green;

                for (; ; )
                {
                    Console.Write("Input three integer number: ");
                    if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("All number is positiv: " + (a>0 && b>0 && c>0));
                        break;
                    }
                    else
                        Console.WriteLine("Input incorrect. Try again. Input integer number.");
                }

                Console.ForegroundColor = tmp_color;

                Console.WriteLine("For EXIT - press Escape.");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }

            Console.ForegroundColor = tmp_color;

            Console.WriteLine("\n\n\tEXIT\t");
            Console.ReadKey();
            return;
        }
    }
}
