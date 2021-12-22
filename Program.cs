using BenchmarkDotNet.Running;
using Microsoft.TeamFoundation.Common.Internal;
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
            Console.WriteLine("4 - Двусвязный список");
            Console.WriteLine("5 - BenchMark");
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
            else if (n == "4")
            {
                var List = new WILinkedList();
                //List.AddNodeAfter( , 3);
                List.AddNode(1);
                List.PrintList();
                //List.FindNode(0);
                //Console.WriteLine(List.FindNode(0));
                //List.GetCount();
                //List.RemoveNode(1);

            }
            else if (n == "5")
            {
                OUT viv = new OUT();
                viv.output();
                BenchmarkRunner.Run<BenchMark>();
            }
            else if (n == "6")
            {


                var tree = new BinaryTree();
               
                tree.Insert(11);
                tree.Insert(20);
                tree.Insert(40);
                tree.Insert(10);
                tree.Insert(30);
                tree.Insert(80);
                tree.Insert(29);
                tree.Insert(31);
                tree.Insert(32);
                tree.Insert(70);
                BinaryTreeExtensions.Print(tree);
                tree.Remove(40);
                BinaryTreeExtensions.Print(tree);
                tree.Remove(20);
                BinaryTreeExtensions.Print(tree);
            }
            }
        
    }
}
