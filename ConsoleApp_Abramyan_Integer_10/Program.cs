using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Integer_10
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

            Console.WriteLine("\n\n\n\n\tInteger 10");
            Console.WriteLine(
@"
***************************************************************************************************

        Integer10–. Дано трехзначное число. Вывести вначале его последнюю цифру
(единицы), а затем — его среднюю цифру (десятки).

***************************************************************************************************");

            Console.Write("Input integer number: ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string str = a.ToString();
            
            Console.WriteLine($"Last number: {str[str.Length - 1]}");
            if(str.Length>=2)
                Console.WriteLine($"Prelast number: {str[str.Length - 2]}");
            else
                Console.WriteLine("Prelast number is zero.");

            Console.ForegroundColor = tmp_color;

            Console.WriteLine("\n\n\tEXIT\t");
            Console.ReadKey();
            return;
        }
    }
}
