namespace LeetCode.Algorithms;

using System;
using System.Collections.Generic;

class TwoSum_1
{
    public int[] TwoSum(int[] nums, int target) {

        var set = new HashSet<int>();
        foreach (var i in nums)
        {
            var compNum = target - i;
            if (set.Contains(compNum))
            {
                return new int[] {i, compNum};
            }
        }
        
        return Array.Empty<int>();
    }
}
