using CodingChallengeCollection.Algorithms.Arrays;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Array;

public class RemoveElementsTests
{
    [Theory]
    [MemberData(nameof(TestData1), MemberType = typeof(RemoveElementsTests))]
    public void RemoveDuplicates_Test(int[] nums, int[] expected)
    {
        var actualK = RemoveElements.RemoveDuplicates(nums);

        Assert.Equal(expected.Length, actualK);
        for (var i = 0; i < actualK; i++) {
            Assert.Equal(expected[i], nums[i]);
        }
    }

    public static TheoryData<int[], int[]> TestData1 =>
        new()
        {
            {
                [1, 1, 2],
                [1, 2]
            },
            {
                [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],
                [0, 1, 2, 3, 4]
            },
            {
                [1],
                [1]
            },
        };

    [Theory]
    [MemberData(nameof(TestData2), MemberType = typeof(RemoveElementsTests))]
    public void RemoveDuplicates2_Test(int[] nums, int[] expected)
    {
        var actualK = RemoveElements.RemoveDuplicates2(nums);

        Assert.Equal(expected.Length, actualK);
        for (var i = 0; i < actualK; i++) {
            Assert.Equal(expected[i], nums[i]);
        }
    }

    public static TheoryData<int[], int[]> TestData2 =>
        new()
        {
            {
                [1, 1, 1, 2, 2, 3],
                [1, 1, 2, 2, 3]
            },
            {
                [0, 0, 1, 1, 1, 1, 2, 3, 3],
                [0, 0, 1, 1, 2, 3, 3]
            },
            {
                [1],
                [1]
            },
        };
}
