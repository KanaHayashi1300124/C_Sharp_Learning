using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Mul2 : IMul
    {
        public int Calc(int a, int b)
        {
            return a*b;
        }
    }
}