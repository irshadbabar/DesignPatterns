using FlyWeight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FlyweightShapeFactory factory = new FlyweightShapeFactory();
            IShape shape = factory.GetShape("rectangle");
            shape.Draw(10, 20, 30, 40);
            // shape2 would be sharing same object.
            IShape shape2 = factory.GetShape("rectangle");



        }
    }
}
