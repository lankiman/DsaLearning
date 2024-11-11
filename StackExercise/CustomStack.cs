namespace StackExercise
{
    internal class CustomStack<T>
    {
        private T[] items = new T[10];
        private int count;


        public bool IsEmpty()
        {
            return (count < 1);
        }

        public void Print()
        {
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }

        }

        public void Push(T item)
        {
            if (items.Length == count)
            {
                T[] newItems = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newItems[i] = items[i];
                }
            }
            items[count++] = item;
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                var item = items[count - 1];
                items[--count] = default;
                return item;
            }
            return default;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                var item = items[count - 1];
                return item;
            }
            return default;
        }
    }
}
