using HashtablesExercise;

internal class Program
{
    private static void Main(string[] args)
    {

        var hashmap = new CustomHashTable<int, int>();

        hashmap.Put(1, 2);
        hashmap.Put(21, 3);
        hashmap.Remove(21);

        var item = hashmap.Get(21);

        Console.WriteLine(item);



        //var hashMap = new Dictionary<char, int>();

        //string str = "a green apple";
        //string strr = "green apple";
        //char firstNonRepeated;
        //char firstRepeated = '\0';

        //foreach (var ch in str)
        //{
        //    if (hashMap.ContainsKey(ch))
        //    {
        //        hashMap[ch]++;
        //    }
        //    else
        //    {
        //        hashMap[ch] = 1;
        //    }
        //}

        //firstNonRepeated = hashMap.FirstOrDefault(m => m.Value < 2).Key;

        //var toString = $"Dictionary: {{{string.Join(", ", hashMap.Select(kv => $"{kv.Key}={kv.Value}"))}}}";

        //Console.WriteLine(toString);

        //var set = new HashSet<char>();
        //foreach (var ch in strr)
        //{
        //    if (set.Contains(ch))
        //    {
        //        firstRepeated = ch;
        //        break;
        //    }
        //    else
        //    {
        //        set.Add(ch);
        //    }
        //}

        //var strrr = "time don dey go o marvellous";



        //var setToString = $"Set: {{{string.Join(", ", set.Select(kv => $"{kv}"))}}}";
        //Console.WriteLine(setToString);
        //Console.WriteLine(firstRepeated);


        ////int[] TwoSum(int[] nums, int target)
        ////{
        ////    for (int i = 0; i < nums.Length; i++)
        ////    {
        ////        for (int k = 0; k < nums.Length; k++)
        ////        {
        ////            if (i != k)
        ////            {
        ////                if (nums[i] + nums[k] == target)
        ////                {
        ////                    return new int[] { i, k };
        ////                }
        ////            }
        ////        }
        ////    }

        ////    return [-1];
        ////}

        ////int[] TwoSum(int[] nums, int target)
        ////{

        ////    for (int i = 0; i < nums.Length; i++)
        ////    {

        ////        var numbers = new Dictionary<int, int>();

        ////        var targetCase = target - nums[i];
        ////        if (numbers.ContainsKey(targetCase))
        ////        {
        ////            return new int[] { numbers[targetCase], i };
        ////        }

        ////        numbers[nums[i]] = i;
        ////    }
        ////    return [-1];
        ////}



        //int[] TwoSum(int[] nums, int target)
        //{
        //    var map = new Dictionary<int, List<int>>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int complement = target - nums[i];


        //        if (map.ContainsKey(complement))
        //        {

        //            if (complement == nums[i] && map[complement].Count > 1)
        //            {
        //                return new int[] { map[complement][0], map[complement][1] };
        //            }
        //            else
        //            {
        //                return new int[] { map[complement][0], i };
        //            }
        //        }


        //        if (!map.ContainsKey(nums[i]))
        //        {
        //            map[nums[i]] = new List<int>();
        //        }
        //        map[nums[i]].Add(i);
        //        Console.WriteLine($"Result Index: [{string.Join(" ", map[nums[i]].Select(r => r))}]");
        //    }

        //    throw new ArgumentException("No two sum solution"); // If no solution is found
        //}



        //var result = TwoSum([1, 9, 9, 9, 4, 9], 18);

        //var resultJoin = $"Result Index: [{string.Join(" ", result.Select(r => r))}]";
        //Console.WriteLine(resultJoin);

        ////int LengthOfLongestSubstring(string s)
        ////{
        ////    int length = 0;
        ////    int index = 0;
        ////    var strings = new Dictionary<char, int>();
        ////    var lists = new List<int>();

        ////    for (int i = 0; i < s.Length; i++)
        ////    {
        ////        strings.Add(s[i], index++);
        ////        length = 1;
        ////        for (int k = i + 1; k < s.Length; k++)
        ////        {       
        ////            if (strings.ContainsKey(s[k]))
        ////            {
        ////                strings.Clear();
        ////                lists.Add(length);
        ////                break;
        ////            }
        ////            else
        ////            {
        ////                strings.Add(s[k], index++);
        ////                length += 1;
        ////            }
        ////            if (s.Length - k == 1)
        ////            {
        ////                lists.Add(length);
        ////            }
        ////        }
        ////        strings.Clear();
        ////    }
        ////    int max = 0;
        ////    if (lists.Count > 0)
        ////    {
        ////        max = lists[0];
        ////    }

        ////    foreach (int item in lists)
        ////    {
        ////        if (item > max)
        ////        {
        ////            max = item;
        ////        }
        ////    }
        ////    return lists.Count > 0 ? max : length;
        ////}


        //int LengthOfLongestSubstring(string s)
        //{
        //    var map = new Dictionary<char, int>();
        //    int maxLength = 0;
        //    int start = 0;

        //    for (var i = 0; i < s.Length; i++)
        //    {
        //        if (map.ContainsKey(s[i]) && map[s[i]] >= start)
        //        {
        //            start = map[s[i]] + 1;
        //        }

        //        map[s[i]] = i;

        //        maxLength = Math.Max(maxLength, i - start + 1);
        //    }

        //    return maxLength;
        //}
        //var maxnumber = LengthOfLongestSubstring("dvdf");
        //Console.WriteLine(maxnumber);

    }


}
