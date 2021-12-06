using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class scheme
    {
        public void blockscheme()
        {
            Console.WriteLine("введите число для определения простое оно или сложное");
            int n = Int32.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
                if (d == 0)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число  не простое");
                }
            

        }
    }
}
