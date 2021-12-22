using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class FibonachiYes
    {
        public void WithRecursion()
        {
            {
                Console.WriteLine("Введите номер элемента последовательности Фибоначчи: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fib(n));
            }
            static int fib(int n)
            {
                if (n < 2)
                {
                    return n;
                }
                return (fib(n - 1) + fib(n - 2));
            }
        }
    }
}