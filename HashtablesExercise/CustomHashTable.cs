namespace HashtablesExercise
{

    internal class CustomHashTable<K, T>
    {
        private class Entry
        {
            public K key;
            public T value;
        }

        private LinkedList<Entry>[] _array = new LinkedList<Entry>[20];

        private int Hash(K key)
        {
            int index = 0;
            foreach (char ch in Convert.ToString(key))
            {
                index += ch;
            }
            return index % _array.Length;
        }

        public void Put(K key, T value)
        {
            int index = Hash(key);
            var input = new LinkedList<Entry>();
            var entry = new Entry { key = key, value = value };
            input.AddLast(entry);
            if (_array[index] == null)
            {

                _array[index] = input;
            }
            else
            {
                input.AddLast(entry);
            }
        }

        public T Get(K key)
        {
            int index = Hash(key);

            if (index >= _array.Length || _array[index] == null)
            {
                throw new KeyNotFoundException();
            }

            foreach (var entry in _array[index])
            {
                if (entry.key.Equals(key))
                {
                    return entry.value;
                }
            }

            return default;
        }

        public void Remove(K key)
        {
            int index = Hash(key);

            object temp = null;

            if (index >= _array.Length || _array[index] == null)
            {
                throw new KeyNotFoundException();
            }

            foreach (var entry in _array[index])
            {
                if (entry.key.Equals(key))
                {
                    temp = entry;
                }
            }

            if (temp != null)
                _array[index].Remove((Entry)temp);


        }
    }
}
