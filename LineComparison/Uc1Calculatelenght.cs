using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class Uc1Calculatelenght
    {
        public static void CalculateLength()
        {
            Console.WriteLine("Enter value of X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------Calculate Lenght of one Line-----------------------");
            Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            Console.WriteLine("--------2 decimal point------");
            double result= Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
