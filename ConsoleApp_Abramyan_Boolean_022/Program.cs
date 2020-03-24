using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Boolean_022
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

            Console.WriteLine("\n\n\n\n\tBoolean 22");
            Console.WriteLine(
@"
***************************************************************************************************

        Boolean22–. Дано трехзначное число. Проверить истинность высказывания:
«Цифры данного числа образуют возрастающую или убывающую последовательность».

***************************************************************************************************");

            int a;

            bool repeat = true;
            while (repeat)
            {

                Console.ForegroundColor = ConsoleColor.Green;

                for (; ; )
                {
                    Console.Write("Input integer number: ");
                    if (int.TryParse(Console.ReadLine(), out a) && a > 0)
                    {
                        string str = a.ToString();
                        var iUp = str[0];
                        var iDown = str[0];
                        bool flagUp = true, flagDown = true;
                        for(var i = 0;i<str.Length;i++)
                        {
                            if (iUp > str[i])
                                flagUp = false;
                            iUp = str[i];

                            if (iDown < str[i])
                                flagDown = false;
                            iDown = str[i];
                        }
                        if(flagUp)
                            Console.WriteLine("The Number is an ascending sequence.");
                        else
                        if (flagDown)
                            Console.WriteLine("The Number is an descending sequence.");
                        else
                            Console.WriteLine("The Number is not an sequence.");

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
