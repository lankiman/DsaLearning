namespace QueueExecercise
{
    internal class CustomStackQueue<T>
    {
        private Stack<T> _inputStack = new();
        private Stack<T> _outputStack = new();
        private int _count;
        public int Count { get { return _count; } }

        public CustomStackQueue()
        {
            _count = _outputStack.Count;
        }

        public void Enqueue(T item)
        {
            _inputStack.Push(item);
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot Dequeue and Empty queue");
            }
            if (_outputStack.Count == 0)
            {
                while (_inputStack.Count != 0)
                {
                    _outputStack.Push(_inputStack.Pop());
                }
            }
            var item = _outputStack.Pop();
            return item;
        }

        public bool IsEmpty()
        {
            return _inputStack.Count == 0 && _outputStack.Count == 0;
        }

        public T Peek()
        {
            var item = _outputStack.Peek();
            return item;
        }
    }
}
