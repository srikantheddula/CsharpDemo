using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class CheckNumIsEvenROdd
    {
       
       public  static void Checking()
        {
            Console.WriteLine("enter a number");
           int num =Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even");
                }

                else
                {
                    Console.WriteLine("odd");
                }
            }
            else
            {
                Console.WriteLine("enter positive number");
            }

        }
        

    }  
}
