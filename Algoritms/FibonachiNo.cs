using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class FibonachiNO
    {
        public void NoRecursion()
        {
            Console.WriteLine("Сколько чисел ряда Фибоначчи вывести на консоль?");
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 1;
            Console.Write("{0} ", first);
            int second = 1;
            Console.Write("{0} ", second);
            int sum = 0;
            for (int i = 0; i < number - 2; i++)

            {
                sum = first + second;

                Console.Write("{0} ", sum);

                first = second;
                second = sum;
            }
        }
    }
}