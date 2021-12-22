using System;

namespace _1._1
{

    class Program
    {           
        static void Main(string[] args)
        {
            Console.WriteLine("Для вывода решения введите цифру где  : ");
            Console.WriteLine("1 - блоксхема");
            Console.WriteLine("2 - вычисление числа Фибоначи без рекурсии");
            Console.WriteLine("3 - вычисление числа Фибоначи с рекурсией");
            string n = Console.ReadLine();
            if (n == "1")
            {
                var Scheme = new scheme();
                Scheme.blockscheme();
            }
            else if (n == "2")
            {
                var _NoRecursion = new FibonachiNO();
                _NoRecursion.NoRecursion();
            }
            else if (n == "3")
            {
                var _WithRecursion = new FibonachiYes();
                _WithRecursion.WithRecursion();
            }

        }
        
    }
}
