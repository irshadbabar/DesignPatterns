using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator : IEnumerator<int>
    {
        private int _currentIndex = -1;
        private ConcreteAggregate _aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public int Current
        {
            get { return _aggregate._items[_currentIndex]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _aggregate._items.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public void Dispose()
        {
            _aggregate = null;
        }
    }
}

