using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class PowerOfTwo
    {
        public static void FindPowerOfTwo()
        {
            
            Console.Write("Insert a number");
            int N = Convert.ToInt32(Console.ReadLine());
            if (0 <= N && N < 31)
            {
                for (int i = 1; i <= N; i++)
                {

                    int result = (int)Math.Pow(2, i);
                    Console.WriteLine(result);
                }
            }
            else Console.WriteLine("enter num below 31");
        }
           

    }
}
