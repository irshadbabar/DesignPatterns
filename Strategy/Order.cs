using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Order
    {
        private IShippingCostStrategy _shippingCostStrategy;

        public Order(IShippingCostStrategy shippingCostStrategy)
        {
            _shippingCostStrategy = shippingCostStrategy;
        }

        public int CalculateShippingCost()
        {
            return _shippingCostStrategy.Calculate(this);
        }
    }
}
