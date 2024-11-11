using LinkedListExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        var linkedList = new SinglyLinkedList<int>();



        linkedList.AddFirst(6);
        linkedList.AddFirst(5);
        linkedList.AddFirst(4);
        linkedList.AddFirst(3);
        linkedList.AddFirst(2);
        linkedList.AddFirst(1);
        linkedList.AddLast(7);
        linkedList.AddLast(8);
        linkedList.AddLast(9);
        linkedList.AddLast(10);
        linkedList.AddLast(11);
        linkedList.AddLast(12);
        linkedList.AddLast(13);


        Console.WriteLine("Before Reverse");
        linkedList.Print();

        Console.WriteLine("This node from the end is {0}", linkedList.FindKthNode(0));
        //linkedList.printTail();

        //linkedList.TutorReverse();
        //Console.WriteLine("After Reverse");
        //linkedList.Print();
        //linkedList.printTail();
    }
}