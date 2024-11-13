internal class Program
{
    private static void Main(string[] args)
    {

        var hashMap = new Dictionary<char, int>();

        string str = "a green apple";
        char firstOccurence;

        foreach (var ch in str)
        {
            if (hashMap.ContainsKey(ch))
            {
                hashMap[ch]++;
            }
            else
            {
                hashMap[ch] = 1;
            }
        }



        firstOccurence = hashMap.FirstOrDefault(m => m.Value < 2).Key;


        var toString = $"Dictionary: {{{string.Join(", ", hashMap.Select(kv => $"{kv.Key}={kv.Value}"))}}}";

        Console.WriteLine(toString);


        Console.WriteLine(firstOccurence);

        var set = new HashSet<int>();

        set.Add(1);
        set.Add(1);

        var setToString = $"Set: {{{string.Join(", ", set.Select(kv => $"{kv}"))}}}";
        Console.WriteLine(setToString);

    }
}