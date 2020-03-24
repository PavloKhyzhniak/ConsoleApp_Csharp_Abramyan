﻿using System;
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
            
            Console.WriteLine("\n\n\n\n\tBoolean 02");
            Console.WriteLine(
@"
***************************************************************************************************

        Boolean2–. Дано целое число A. Проверить истинность высказывания: 
«Число A является нечетным».

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
                        Console.WriteLine("Number is " + ((a%2==1)?"odd":"even"));
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
