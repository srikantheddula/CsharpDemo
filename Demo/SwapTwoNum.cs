using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    internal class SwapTwoNum
    {
        int temp=0;
        public void ReadInputs()
        {
            Console.WriteLine("enter first num:");
            int first= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before Swap:"+first+second);

            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("After Swap:" + first + second);


        }



    }
}
