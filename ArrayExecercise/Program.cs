using ArrayExecercise;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayClass test = new(7);
        test.Insert("TIME");
        test.Insert("IS");
        test.Insert(2);
        test.Insert("e dey work");
        test.Insert("e dey work");
        test.Insert("e dey work");
        test.Insert("e dey work");
        test.Insert("e dey work");
        test.RemoveAt(0);
        test.Print();
    }
}