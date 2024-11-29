namespace CodingChallengeCollection.Algorithms.Arrays;

public class MergeArrays
{
    /* EASY
     * You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
     * and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
     * Merge nums1 and nums2 into a single array sorted in non-decreasing order.
     * The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
     * To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
     * and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
     *
     * Example 1:
     *
     * Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
     * Output: [1,2,2,3,5,6]
     * Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
     * The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
     */
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var cursor1 = 0;
        var cursor2 = 0;
        var temp = new int[m + n];

        if (n == 0) return;

        for (var i = 0; i < m+n; i++)
        {
            if (cursor1 >= nums1.Length)
            {
                temp[i] = nums2[cursor2];
                cursor2++;
                continue;
            }

            if (cursor2 >= nums2.Length)
            {
                temp[i] = nums1[cursor1];
                cursor1++;
                continue;
            }

            if (cursor1 < m && nums1[cursor1] <= nums2[cursor2])
            {
                temp[i] = nums1[cursor1];
                cursor1++;
            }
            else
            {
                temp[i] = nums2[cursor2];
                cursor2++;
            }
        }

        for (var i = 0; i < m+n; i++)
        {
            nums1[i] = temp[i];
        }
    }
}
