using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern;

namespace StatePattern
{
    internal interface Mobile : Device
    {
        public void GetNotificaitons();
    }
}
