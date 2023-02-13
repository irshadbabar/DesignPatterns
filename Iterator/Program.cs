using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate.Add(1);
            aggregate.Add(2);
            aggregate.Add(3);

            foreach (int item in aggregate)
            {
                Console.WriteLine(item);
            }
        }
    }
}
