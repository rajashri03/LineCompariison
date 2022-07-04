using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Select Option\n1)Calculate Length\n2)Check Equality of lines\n");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Uc1Calculatelenght.CalculateLength();
                        break;
                    case 2:
                        UC2_CheckEquality.CheckEquality();
                        break;
                    default:
                        check = !check;
                        break;
                }
            }
        }
    }
}
