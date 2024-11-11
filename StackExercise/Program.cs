using StackExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        //var str = "abcd";
        //var rvstr = new StringBuilder();
        //var stack = new Stack<char>();

        //foreach (var s in str)
        //{
        //    stack.Push(s);
        //}

        //foreach (var item in stack)
        //{
        //    rvstr.Append(item);
        //}
        //Console.WriteLine(rvstr);

        var stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Print();
        var item = stack.Peek();
        Console.WriteLine(item);

        stack.Print();
    }
}