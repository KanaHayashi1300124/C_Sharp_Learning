using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Mul1 : IMul
    {
        public int Calc(int a, int b)
        {
            int result = 0;
            fir(int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }
    }
}