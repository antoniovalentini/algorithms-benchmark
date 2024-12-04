using CodingChallengeCollection.Algorithms.Arrays;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Array;

public class ArrowsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void MergeArrays_Test(string s, int expected)
    {
        var actual = Arrows.Run(s);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<string, int> TestData =>
        new()
        {
            { "^vv<",   3 },
            { "vv>>vv", 4 },
            { "<<<",    0 },
        };
}
