using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;

namespace Algoritms
{

    class OUT
    {
        public void output()
        {
            Distanse pointFloat = new Distanse();
            pointFloat.DistanseFloat();


            StructFloat StructurFloat = new StructFloat();
            StructurFloat.StructFloats();


            DDistanse StructurDouble = new DDistanse();
            StructurDouble.DistanseDouble();


            StructFloats StructurNoSqrt = new StructFloats();
            StructurNoSqrt.StructFloatNOSqrt();

        }
    }
}

