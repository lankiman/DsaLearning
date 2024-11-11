namespace QueueExecercise
{
    internal class CustomQueue<T>
    {
        private T[] _array;
        private int _count;
        private int _maxCapacity;
        private int _head;
        private int _tail;
        public int Count { get { return _count; } }

        public CustomQueue()
        {
            _array = Array.Empty<T>()
            _maxCapacity = 5;
        }

        private void Resize(int capacity)
        {
            OverFlow(capacity);
            T[] newArray = new T[capacity];

            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
            _head = 0;
            _tail = (_count == _array.Length) ? 0 : _count;
        }

        private void Grow(int capcity)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan<int>(capcity, 1);
            const int growFactor = 2;
            const int minimumGrow = 4;
            const int reduceExponentialFactor = 20;

            int newCapacity = growFactor * _array.Length;

            if (newCapacity > reduceExponentialFactor)
            {
                newCapacity = reduceExponentialFactor;
            }

            newCapacity = Math.Max(newCapacity, _array.Length + minimumGrow);

            if (newCapacity < capcity)
            {
                newCapacity = capcity;
            }



            Resize(newCapacity);

        }
        private void OverFlow(int capactiy)
        {
            if (capactiy > _maxCapacity)
            {
                throw new InvalidOperationException("Maximum Queue Capacity Reached, Cannot Add more Items");

            }
        }

        private bool IsMaxCapacity()
        {
            return _array.Length >= _maxCapacity;
        }

        public bool IsFull()
        {
            return _array.Length == _count;
        }


        public bool IsEmpty()
        {
            return _count == 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull() && !IsMaxCapacity())
            {
                Grow(_count + 1);
            }

            if (IsFull() && IsMaxCapacity())
            {
                throw new InvalidOperationException("The operation cannot be performed because the queue is full and at max capcity, please dequue or create a new queue.");
            }
            _array[_tail] = item;
            _count++;
            _tail = (_tail + 1) % _array.Length;


        }

        public T Dequeue()
        {
            if (!IsEmpty())
            {
                var item = _array[_head];
                _array[_head] = default;
                _head = (_head + 1) % _array.Length;
                _count--;
                return item;

            }
            return default;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                var item = _array[_head];
                return item;
            }
            return default;
        }

        public override string ToString()
        {
            return String.Join(" ", _array);
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                for (int i = _head; i < _head + _count; i++)
                {
                    Console.WriteLine(_array[i % _array.Length]);
                }
            }
            else
            {
                Console.WriteLine("Queue is Empty");
            }

            Console.WriteLine("Lenght {0}", _array.Length);
        }
    }
}
