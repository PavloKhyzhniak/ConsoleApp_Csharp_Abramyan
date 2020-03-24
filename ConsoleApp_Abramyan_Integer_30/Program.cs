using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Integer_30
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

            Console.WriteLine("\n\n\n\n\tBegin 30");
            Console.WriteLine(
@"
***************************************************************************************************

        Integer30–. Дан номер некоторого года (целое положительное число). Определить
соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.

***************************************************************************************************");

            int a;
       
            bool repeat = true;
            while (repeat)
            {

                for (; ; )
                {
                    Console.Write("Input positiv integer number - year: ");
                    if (int.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        Console.WriteLine("Столетие = " + ((int)(a / 100) + 1));
                        break;
                    }
                    else
                        Console.WriteLine("Input incorrect. Try again. Input integer number.");
                }

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
