using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class IPhone : Mobile
    {
        public void GetNotificaitons()
        {
            Console.WriteLine("Getting notificaitons for iphone phone");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off iphone device");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on iphone device");
        }
    }
}
