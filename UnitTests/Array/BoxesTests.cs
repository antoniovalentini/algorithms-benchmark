using CodingChallengeCollection.Algorithms.Arrays;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Array;

public class BoxesTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Boxes_Test(int[] a, int expected)
    {
        var actual = Boxes.Run(a);
        Assert.Equal(expected, actual);
    }

    public static TheoryData<int[], int> TestData =>
        new()
        {
            { [7, 15, 10, 8],              7 },
            { [11, 10, 8, 12, 8, 10, 11],  6 },
            { [7, 14, 10],                -1 },
        };
}
