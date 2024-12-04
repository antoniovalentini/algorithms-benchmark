using CodingChallengeCollection.Algorithms.SlidingWindow;
using Xunit;

namespace CodingChallengeCollection.UnitTests.SlidingWindow;

public class LengthOfLongestSubstringTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void LengthOfLongestSubstring_Test(string s, int expected)
    {
        var min = LengthOfLongestSubstring.Run(s);

        Assert.Equal(expected, min);
    }

    public static TheoryData<string, int> TestData =>
        new()
        {
            {
                "abcabcbb",
                3
            },
            {
                "bbbbb",
                1
            },
            {
                "pwwkew",
                3
            },
        };
}
