using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Client
    {
        static void Main(string[] args)
        {
            ConcretePrototypeA prototypeA = new ConcretePrototypeA(30);
            ConcretePrototypeA cloneA = (ConcretePrototypeA)prototypeA.Clone();
            Console.WriteLine("Cloned: {0}", cloneA.Age);

            ConcretePrototypeB prototypeB = new ConcretePrototypeB("John");
            ConcretePrototypeB cloneB = (ConcretePrototypeB)prototypeB.Clone();
            Console.WriteLine("Cloned: {0}", cloneB.Name);

            Console.ReadKey();
        }
    }
}
