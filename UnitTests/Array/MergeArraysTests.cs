using CodingChallengeCollection.Algorithms.Arrays;
using Xunit;

namespace CodingChallengeCollection.UnitTests.Array;

public class MergeArraysTests
{
    [Theory]
    [MemberData(nameof(TestData), MemberType = typeof(MergeArraysTests))]
    public void MergeArrays_Test(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        MergeArrays.Merge(nums1, m, nums2, n);
        Assert.Equal(expected, nums1);
    }

    public static TheoryData<int[], int, int[], int, int[]> TestData =>
        new()
        {
            {
                [1, 2, 3, 0, 0, 0], 3,
                [2, 5, 6], 3,
                [1, 2, 2, 3, 5, 6]
            },
            {
                [1], 1,
                [], 0,
                [1]
            },
            {
                [0], 0,
                [1], 1,
                [1]
            },
            {
                [2,0], 1,
                [1], 1,
                [1, 2]
            },
            {
                [-1,0,0,3,3,3,0,0,0], 6,
                [1,2,2], 3,
                [-1,0,0,1,2,2,3,3,3]
            },
        };
}
