using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class ExpressShippingCostStrategy : IShippingCostStrategy
    {
        public int Calculate(Order order)
        {
            return 10;
        }
    }
}
