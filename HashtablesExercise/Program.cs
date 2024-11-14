internal class Program
{
    private static void Main(string[] args)
    {

        var hashMap = new Dictionary<char, int>();

        string str = "a green apple";
        string strr = "green apple";
        char firstNonRepeated;
        char firstRepeated = '\0';

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

        firstNonRepeated = hashMap.FirstOrDefault(m => m.Value < 2).Key;

        var toString = $"Dictionary: {{{string.Join(", ", hashMap.Select(kv => $"{kv.Key}={kv.Value}"))}}}";

        Console.WriteLine(toString);

        var set = new HashSet<char>();
        foreach (var ch in strr)
        {
            if (set.Contains(ch))
            {
                firstRepeated = ch;
                break;
            }
            else
            {
                set.Add(ch);
            }
        }

        var strrr = "time don dey go o marvellous";



        var setToString = $"Set: {{{string.Join(", ", set.Select(kv => $"{kv}"))}}}";
        Console.WriteLine(setToString);
        Console.WriteLine(firstRepeated);


        //int[] TwoSum(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int k = 0; k < nums.Length; k++)
        //        {
        //            if (i != k)
        //            {
        //                if (nums[i] + nums[k] == target)
        //                {
        //                    return new int[] { i, k };
        //                }
        //            }
        //        }
        //    }

        //    return [-1];
        //}

        //int[] TwoSum(int[] nums, int target)
        //{

        //    for (int i = 0; i < nums.Length; i++)
        //    {

        //        var numbers = new Dictionary<int, int>();

        //        var targetCase = target - nums[i];
        //        if (numbers.ContainsKey(targetCase))
        //        {
        //            return new int[] { numbers[targetCase], i };
        //        }

        //        numbers[nums[i]] = i;
        //    }
        //    return [-1];
        //}



        int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];


                if (map.ContainsKey(complement))
                {

                    if (complement == nums[i] && map[complement].Count > 1)
                    {
                        return new int[] { map[complement][0], map[complement][1] };
                    }
                    else
                    {
                        return new int[] { map[complement][0], i };
                    }
                }


                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = new List<int>();
                }
                map[nums[i]].Add(i);
                Console.WriteLine($"Result Index: [{string.Join(" ", map[nums[i]].Select(r => r))}]");
            }

            throw new ArgumentException("No two sum solution"); // If no solution is found
        }



        var result = TwoSum([1, 9, 9, 9, 4, 9], 18);

        var resultJoin = $"Result Index: [{string.Join(" ", result.Select(r => r))}]";
        Console.WriteLine(resultJoin);

        int LengthOfLongestSubstring(string s)
        {

            int length = 0;
            int index = 0;
            var strings = new Dictionary<char, int>();
            var lists = new List<int>();
            // loop throug the string
            for (int i = 0; i < s.Length; i++)
            {
                var test = s[i];

                strings.Add(s[i], index++);
                length = 1;
                int count = 0;

                for (int k = i + 1; k < s.Length; k++)
                {
                    count = count + 1;
                    var testk = s[k];
                    if (strings.ContainsKey(s[k]))
                    {
                        strings.Clear();
                        lists.Add(length);
                        break;
                    }
                    else
                    {
                        strings.Add(s[k], index++);
                        length += 1;
                    }
                    if (s.Length - k == 1)
                    {
                        lists.Add(length);
                    }
                }
                strings.Clear();
            }


            int max = 0;
            if (lists.Count > 0)
            {
                max = lists[0];
            }

            foreach (int item in lists)
            {
                //Console.WriteLine($"item:{item}, max:{max}");
                if (item > max)
                {
                    max = item;

                }
            }
            return lists.Count > 0 ? max : length;
        }

        var lenghtResult = LengthOfLongestSubstring("pkwtt");
        Console.WriteLine($"length result {lenghtResult}");
    }

    // takes in the key and value in a normal order;
    public class TwoSumDictionary<Tkey, Tvalue>
    {
        //takes the values as the key and the key as a hash set in the array
        private Dictionary<Tvalue, HashSet<Tkey>> _dictionary;

        //takes the array in a normal order
        private Dictionary<Tkey, Tvalue> _idexes;

        public void Add(Tkey key, Tvalue value)
        {
            if (_dictionary.ContainsKey(value))
            {
                _dictionary[value].Add(key);
            }
            else
            {
                _dictionary[value] = [key];
            }
            _idexes.Add(key, value);
        }


    }
}
