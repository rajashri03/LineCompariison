using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class UC3_Compare
    {
        public static void CompareLine()
        {
            Console.WriteLine("Enter first line co-ordinates");
            Console.WriteLine("Enter value of X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------Length of First Line-----------------------");
            double line1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(line1);

            Console.WriteLine("Enter Second line co-ordinates");
            Console.WriteLine("Enter value of A1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of A2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B2");
            int b2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------Length of second Line-----------------------");
            double line2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
            Console.WriteLine(line2);

            int result = line1.CompareTo(line2);
            if(result>0)
            {
                Console.WriteLine("Line 1 is greater than line2");
            }
            else if (result < 0)
            {
                Console.WriteLine("Line 2 is greater than line1");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
    }
}
