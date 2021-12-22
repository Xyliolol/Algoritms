using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
namespace _1._1
{
    public struct StructFloat
    {

        public float X { get; set; }
        public float Y { get; set; }
        public StructFloat(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void StructFloats()
        {
            Console.WriteLine("                 тест 2");
            int o = 20;
            int j = 20;
            double[] array = new double[o];
            Random r = new Random();
            for (int i = 1; i < j; i++)
            {
                var PointFloatA = new Distanse(r.Next(1000), r.Next(1000));
                var PointFloatB = new Distanse(r.Next(1000), r.Next(1000));
                array[i] = Math.Sqrt((PointFloatA.X + PointFloatB.X) + (PointFloatA.Y + PointFloatB.Y));
                Console.WriteLine(array[i]);
            }
        }
    }
}
