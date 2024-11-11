using QueueExecercise;

internal class Program
{
    private static void Main(string[] args)
    {
        var items = new CustomStackQueue<int>();


        var item = items.Dequeue();

        Console.WriteLine(item);


    }
}