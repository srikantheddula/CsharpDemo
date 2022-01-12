using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class FlipCoinPercentage
    {
        int head = 0;
        int tail = 0;
       
        Random ran = new Random();
        public void flip()
        {
            Console.WriteLine("Enter num to flip a coin");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<num;i+=1)
            {
                double r=ran.NextDouble();
                if (r > 0.5)
                {
                    Console.WriteLine("num is Head");
                    head++;
                }
                else
                {
                    Console.WriteLine("num is Tail");
                    tail+=1;
                }

            }

            Console.WriteLine("tail Count" + tail);
            Console.WriteLine("head Count"+head);
            Console.WriteLine("headpercentage"+(head) * 100 / num+"%");
            Console.WriteLine("tailpercentage" + (tail) * 100 / num+"%");

        }
    }
}
