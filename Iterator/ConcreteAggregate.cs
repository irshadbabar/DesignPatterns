using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteAggregate : IEnumerable<int>
    {
        public List<int> _items = new List<int>();

        public void Add(int item)
        {
            _items.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new ConcreteIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}