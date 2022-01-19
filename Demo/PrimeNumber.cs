using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class PrimeNumber
    {


        public   PrimeNumber()
        {
            Console.WriteLine("Enter a num");
           int num= Convert.ToInt32(Console.ReadLine());
            int  i = 2;
            bool flag = false;

            while (i <= num / 2)
            {
                // condition for nonprime number

                if (num % i == 0)
                {
                    flag = true;
                    break;
                }

                ++i;
            }

            if (!flag)
                Console.WriteLine(num + " is a prime number.");
            else
                Console.WriteLine(num + " is not a prime number.");
        }
    }
}
