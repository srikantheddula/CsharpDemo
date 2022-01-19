using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class LargestNumber
    {
        int num1, num2,num3,result;
        public LargestNumber(int a, int b, int c)
        {
            num1 = a;
            num2 = b;
            num3 = c;

            }

        public void FindlargestAmongThree()
        {

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three. \n");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three. \n");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three. \n");
            }

        }
    }
}
