using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abramyan_Begin_30
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

            Console.WriteLine("\n\n\n\n\tBegin 30");
            Console.WriteLine(
@"
***************************************************************************************************

        Begin30–. Дано значение угла fi в радианах (0 < fi < 2Pi). Определить значение
этого же угла в градусах, учитывая, что 180– = Pi радианов. В качестве
значения Pi использовать 3.14.

***************************************************************************************************");

            Console.Write("Input angle in radian: ");
            double angle_rad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double angle_grad = rad_to_grad(angle_rad);
            Console.WriteLine($"Angle in grad = {angle_grad,5:N2}");
            Console.WriteLine($"Angle in rad = {grad_to_rad(angle_grad),5:N2}");

            Console.ForegroundColor = tmp_color;

            Console.ReadKey();
            return;
        }

        static private double grad_to_rad(double grad)
        {
            return (grad/180*Math.PI);
        }
        static private double rad_to_grad(double rad)
        {
            return (rad / Math.PI * 180);
        }
    }
}
