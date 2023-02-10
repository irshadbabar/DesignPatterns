using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ConcretePrototypeA : ProtoType
    {
        public int Age { get; set; }

        public ConcretePrototypeA(int age)
        {
            this.Age = age;
        }
    }
}
