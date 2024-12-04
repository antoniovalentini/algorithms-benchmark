using System;
using System.Collections.Generic;

namespace CodingChallengeCollection.Algorithms.SlidingWindow;

/// <summary>
/// Given a string s, find the length of the longest substring without repeating characters.
///
/// Example 1:
/// Input: s = "abcabcbb"
/// Output: 3
/// Explanation: The answer is "abc", with the length of 3.
/// </summary>
public static class LengthOfLongestSubstring
{
    public static int Run(string s)
    {
        var n = s.Length;
        var longest = 0;
        var left = 0;
        var chars = new Dictionary<char, int>();

        if (n == 0) return 0;

        for (var right = 0; right < n; right++)
        {
            if (!chars.TryAdd(s[right], 1)) chars[s[right]]++;
            if (chars[s[right]] < 2)
            {
                longest = Math.Max(longest, right - left + 1);
                continue;
            }

            while (chars[s[right]] > 1)
            {
                chars[s[left]]--;
                left++;
            }
        }

        return longest;
    }
}
