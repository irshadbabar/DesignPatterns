using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;


namespace StatePattern
{
    internal class Android : Mobile
    {
        public void GetNotificaitons()
        {
            Console.WriteLine("Getting notificaitons for android phone");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off android device");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on android device");
        }
    }
}
