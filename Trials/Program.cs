using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] nums = new int[] { 1, 1, 2, };
        //int[] expectNums = new int[] { 1, 2 };
        //int index = 0;
        //var result = new Dictionary<int, int>();
        ////var result = new HashSet<int>();
        //foreach (int num in nums)
        //{
        //    if (!result.ContainsKey(num))
        //        result.Add(num, index + 1);
        //    //result.Add(num);
        //}

        //var res = result.Values.ToArray();

        //Console.WriteLine(res[0]);

        //Console.WriteLine($"Dictionary: {{{string.Join(", ", result.Select(kv => $"{kv}"))}}}");
        //Console.WriteLine(result.Count);

        int number = 1;
        var test = number.ToString();
        Console.WriteLine(test);
        Console.WriteLine(test[0]);

        int StrStr(string haystack, string needle)
        {
            StringBuilder checker = new StringBuilder();
            int index = -1;
            int start = 0;
            char pointer = needle[0];
            bool add = false;

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                if (pointer == haystack[i])
                {
                    index = i;
                    checker.Append(haystack[i]);
                    if (checker.ToString() == needle)
                    {
                        return index;
                    }
                    for (int k = i + 1; k < haystack.Length; k++)
                    {
                        checker.Append(haystack[k]);
                        if (checker.Length == needle.Length)
                        {
                            if (checker.ToString() == needle)
                            {
                                return index;
                            }
                            else
                            {
                                index = -1;
                                checker.Clear();
                                break;
                            }

                        }
                    }
                }

            }

            return -1;
        }

        var resulter = StrStr("aaa", "aaaa");
        Console.WriteLine(resulter);


        string LongestCommonPrefix(string[] strs)
        {

        }
    }
}