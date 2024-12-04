using System;

namespace CodingChallengeCollection.Algorithms.SlidingWindow;

public static class MinSubArrayLen
{
    /// <summary>
    /// Given an array of positive integers nums and a positive integer target,
    /// return the minimal length of a subarray whose sum is greater than or equal to target.
    /// If there is no such subarray, return 0 instead.
    ///
    /// Example 1:
    /// Input: target = 7, nums = [2,3,1,2,4,3]
    /// Output: 2
    /// Explanation: The subarray [4,3] has the minimal length under the problem constraint.
    ///
    /// Constraints:
    /// 1 le target le 109
    /// 1 le nums.length le 105
    /// 1 le nums[i] le 104
    /// </summary>
    public static int Run(int target, int[] nums)
    {
        var min = int.MaxValue;
        var n = nums.Length;
        var sum = 0;
        var left = 0;

        for (var right = 0; right < n; right++)
        {
            sum += nums[right];
            while (sum >= target)
            {
                min = Math.Min(min, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return min == int.MaxValue ? 0 : min;
    }
}
