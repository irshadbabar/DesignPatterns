using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyweightShapeFactory
    {
        private Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public IShape GetShape(string shapeName)
        {
            if (!shapes.ContainsKey(shapeName))
            {
                switch (shapeName)
                {
                    case "rectangle":
                        shapes[shapeName] = new Rectangle();
                        break;
                    default:
                        throw new Exception("Unsupported shape");
                }
            }

            return shapes[shapeName];
        }
    }
}
