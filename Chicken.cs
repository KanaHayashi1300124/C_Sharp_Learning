using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Chicken : Bird
    {
        public Chicken() : base("にわとり")
        {

        }

        public override void Sing()
        {
            Console.WriteLine("コケコッコー");
        }
    }
}