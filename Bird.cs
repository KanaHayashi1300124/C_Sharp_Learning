using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    abstract class Bird
    {
        private String name;

        public Bird(String name)
        {
            this.name = name;
        }

        public String Name
        {
            get {return name;}
        }

        public abstract void Sing();
    }
}