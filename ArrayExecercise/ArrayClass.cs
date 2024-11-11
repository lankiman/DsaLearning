namespace ArrayExecercise
{
    internal class ArrayClass(int? length = 0)
    {

        private object[] items = new object[length ?? 0];
        private string error = "";
        private int count;

        public void Insert(object item)
        {
            //time complexity O(n)

            if (items.Length == count)
            {
                var newItems = new object[count * 2];
                for (var i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[count] = item;
                items = newItems;
            }
            items[count++] = item;
        }

        public void RemoveAt(int index)
        {

            if (count == 0)
            {
                error = "Array is Empty";
                return;
            }
            if (count != 0 && (index < 0 || index > count - 1))
            {
                error = "index out of bounds for remove at";
                return;
            }
            for (var i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;

            //items[index] = null;
            //var newItems = new object[count - 1];
            //int newItemIndex = 0;
            //foreach (var item in items)
            //{
            //    if (item != null)
            //    {
            //        newItems[newItemIndex] = item;
            //        newItemIndex++;
            //    }
            //}
            //items = newItems;
            //count--;

        }

        public object IndexOf(int index)
        {
            //runtime complexit 0(1)
            if (index < 0 || index > count - 1)
            {
                return "Index out of bounds for index of";
            }

            return items[index];

        }
        public void Print()
        {
            Console.WriteLine("Count: {0}, Length: {1}", count, items.Length);


            //time complexity 0(n)
            if (!String.IsNullOrEmpty(error))
            {
                Console.WriteLine(error);
                return;
            }
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
