using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    class Pigeion : Bird
    {
        public Pigeion() : base("はと")
        {

        }

        public override void Sing()
        {
            Console.WriteLine("ポッポー");
        }
    }
}