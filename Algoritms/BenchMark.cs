using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algoritms
{
    public class BenchMark

    {
        [Benchmark]
        public void ClassFloat()
        {
            Distanse pointFloat = new Distanse();
            pointFloat.DistanseFloat();
        }
        [Benchmark]
        public void StructFloat()
        {
            StructFloat StructurFloat = new StructFloat();
            StructurFloat.StructFloats();
        }
        [Benchmark]
        public void StructDouble()
        {
            DDistanse StructurDouble = new DDistanse();
            StructurDouble.DistanseDouble();
        }
        [Benchmark]
        public void StructurNoSqrt()
        {
            StructFloats StructurNoSqrt = new StructFloats();
            StructurNoSqrt.StructFloatNOSqrt();
        }

    }
}