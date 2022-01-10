using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class SubtractionTwoNum
    {
       static int sub;
        public static void subtration()
        {
            Console.WriteLine(" subtraction");
            Console.WriteLine(" enter value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter value for b:");
            int b = Convert.ToInt32(Console.ReadLine());

            sub = a - b;
            Console.WriteLine("\n" + sub);
        }
    }
}
