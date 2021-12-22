using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Chess
    {
       
        const int R = 8;
        const int C = 8;
        private int[,] _desk= new int[R, C]; 
 
        public void Start()
        {
            for (int i = 0; i <R; i++)
                _desk[i, 0] = 1;
            for (int j = 0; j < R; j++)
                _desk[0, j] = 1;

            for (int i = 1; i < R; i++)
                for (int j = 1; j < R; j++)
                    _desk[i, j] = _desk[i - 1, j] + _desk[i, j - 1];

            PrintDesk();   
        }

        private void PrintDesk()
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < R; j++)
                    Console.Write($" \t{_desk[i, j]}");
                Console.WriteLine();
            }
        }
    }

}
