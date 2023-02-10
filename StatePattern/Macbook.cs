using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class Macbook : Device
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning off macbook device");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on macbook device");
        }
    }
}
