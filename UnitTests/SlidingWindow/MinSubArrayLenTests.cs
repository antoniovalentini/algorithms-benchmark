using CodingChallengeCollection.Algorithms.SlidingWindow;
using Xunit;

namespace CodingChallengeCollection.UnitTests.SlidingWindow;

public class MinSubArrayLenTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void MinSubArrayLen_Test(int[] nums, int target, int expected)
    {
        var min = MinSubArrayLen.Run(target, nums);

        Assert.Equal(expected, min);
    }

    public static TheoryData<int[], int, int> TestData =>
        new()
        {
            {
                [2, 3, 1, 2, 4, 3],
                7,
                2
            },
            {
                [1, 4, 4],
                4,
                1
            },
            {
                [1, 1, 1, 1, 1, 1, 1, 1],
                11,
                0
            },
            {
                [5],
                5,
                1
            },
            {
                [5, 6, 5, 6],
                8,
                2
            },
        };
}
