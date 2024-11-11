namespace LinkedListExercise
{

    internal class SinglyLinkedList<T>
    {
        private class Node
        {
            internal T value;
            internal Node next;


            public Node(T value)
            {
                this.value = value;

            }
        }

        private Node head;
        private Node tail;
        private int count;

        public void Print()
        {
            var node = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }

        }
        public void AddFirst(T value)
        {
            var newNode = new Node(value);
            if (head == null)
            {
                head = tail = newNode;

            }
            else
            {
                newNode.next = head;

                head = newNode;

            }
            count++;

        }
        public void AddLast(T value)
        {
            var newNode = new Node(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;

                tail = newNode;
            }
            count++;
        }
        public void DeleteFirst()
        {
            var nextHead = head.next;
            head.next = null;
            head = nextHead;
            count--;
        }

        public void DeleteLast()
        {
            if (count > 0)
            {
                var node = head;
                for (int i = 0; i < count; i++)
                {
                    if (node.next == tail)
                    {
                        node.next = null;
                        tail = node;
                        count--;
                        break;
                    }
                    node = node.next;
                }
            }
        }
        public bool Contains(T value)
        {
            if (count > 0)
            {
                var node = head;
                for (int i = 0; i < count; i++)
                {
                    if (node.value.Equals(value))
                    {
                        return true;
                    }
                    node = node.next;
                }
            }
            return false;
        }

        public T[] ToArray()
        {
            var array = new T[count];
            var current = head;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }
            return array;
        }

        public void Reverse()
        {
            var mainHead = head;
            Node newlyShifted = null;
            while (mainHead.next != null)
            {
                newlyShifted = mainHead.next;
                mainHead.next = newlyShifted.next;
                newlyShifted.next = head;
                head = newlyShifted;

                if (newlyShifted == tail)
                {
                    tail = mainHead;
                }
            }

        }


        public void TutorReverse()
        {
            var previous = head;
            var current = previous.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            tail = head;
            tail.next = null;
            head = previous;

        }

        public T FindKthNode(int kthnode)
        {
            //if (kthnode < 1 || kthnode > count)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}

            var index = 0;
            var first = head;
            var second = head;
            while (second.next != null)
            {
                if (index >= kthnode - 1)
                {
                    first = first.next;
                }
                second = second.next;
                index++;
            }
            return first.value;
        }

        public void printTail()
        {

            Console.WriteLine(tail.value);
            Console.WriteLine("next tail", tail.next);
        }
    }
}
