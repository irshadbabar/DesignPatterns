using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class ConcretePrototypeB : ProtoType
    {
        public string Name { get; set; }

        public ConcretePrototypeB(string name)
        {
            this.Name = name;
        }
    }
}
