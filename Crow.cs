using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {

        }

        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}