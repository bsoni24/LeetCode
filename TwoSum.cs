using System;
using System.Collections.Generic;

public class TwoSum
{
    //https://leetcode.com/problems/two-sum/
    
    public int[] Option1(int[] nums, int target)
    {
        var answer = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    answer[0] = i;
                    answer[1] = j;
                    break;
                }
            }
        }
        return answer;
    }

    public int[] Option2(int[] nums, int target)
    {
        //07-15-2021
        //Runtime: 236 ms, faster than 96.17% of C# online submissions for Two Sum.
        //Memory Usage: 33.4 MB, less than 9.36% of C# online submissions for Two Sum.

        var answer = new int[2];
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var value = target - nums[i];

            if (dict.ContainsKey(value))
            {
                var item = dict[value];

                if (item != i)
                {
                    answer[0] = i;
                    answer[1] = item;
                    break;
                }
            }
        }


        return answer;
    }
}