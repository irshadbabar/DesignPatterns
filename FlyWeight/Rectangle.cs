using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Rectangle : IShape
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine("Drawing rectangle at ({0}, {1}) with width {2} and height {3}", x, y, width, height);
        }
    }
}