using QueueExecercise;

internal class Program
{
    private static void Main(string[] args)
    {
        var items = new CustomQueue<int>();
        for (int i = 1; i < 54; i++)
        {
            items.Enqueue(i);
        }

        items.Dequeue();
        items.Enqueue(8);
        items.Print();
        Console.WriteLine("Count of Items {0}", items.Count);
    }
}