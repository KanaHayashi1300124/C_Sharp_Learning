using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Data
    {
        private int num = 0;

        public void Write(int num)
        {
            this.num = num;
        }

        public int Read()
        {
            return num;
        }
    }
}