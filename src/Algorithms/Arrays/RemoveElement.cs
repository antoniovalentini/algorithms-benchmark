namespace CodingChallengeCollection.Algorithms.Arrays;

public class RemoveElements
{
    /*
     * Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
     * The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
     *
     * Consider the number of elements in nums which are not equal to val be k, to get accepted,
     * you need to do the following things:
     * - Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
     * - Return k.
     *
     * Example 1:
     * Input: nums = [3,2,2,3], val = 3
     * Output: 2, nums = [2,2,_,_]
     * Explanation: Your function should return k = 2, with the first two elements of nums being 2.
     * It does not matter what you leave beyond the returned k (hence they are underscores).
     */
    public static int RemoveElement(int[] nums, int val) {
        var k = 0;
        var cursor1 = 0;
        var cursor2 = nums.Length - 1;

        if (nums.Length == 0) return 0;

        while (cursor1 <= cursor2){
            if (nums[cursor1] == val)
            {
                nums[cursor1] = nums[cursor2];
                cursor2--;
            }
            else
            {
                cursor1++;
                k++;
            }
        }
        return k;
    }

    /*
     * Given an integer array nums sorted in non-decreasing order,
     * remove the duplicates in-place such that each unique element appears only once.
     * The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
     *
     * Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
     * - Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially.
     *   The remaining elements of nums are not important as well as the size of nums.
     * - Return k.
     *
     * Example 1:
     * Input: nums = [1,1,2]
     * Output: 2, nums = [1,2,_]
     * Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
     * It does not matter what you leave beyond the returned k (hence they are underscores).
     */
    public static int RemoveDuplicates(int[] nums)
    {
        var n = nums.Length;
        if (n <= 1) return n;

        var j = 0;
        for (var i = 0; i < n; i++)
        {
            if (j < 1 || nums[i] != nums[j - 1])
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }

    /*
     * Given an integer array nums sorted in non-decreasing order,
     * remove some duplicates in-place such that each unique element appears at most twice.
     * The relative order of the elements should be kept the same.
     *
     * Since it is impossible to change the length of the array in some languages,
     * you must instead have the result be placed in the first part of the array nums.
     * More formally, if there are k elements after removing the duplicates,
     * then the first k elements of nums should hold the final result.
     * It does not matter what you leave beyond the first k elements.
     *
     * Return k after placing the final result in the first k slots of nums.
     *
     * Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
     *
     * Example 1:
     * Input: nums = [1,1,1,2,2,3]
     * Output: 5, nums = [1,1,2,2,3,_]
     * Explanation: Your function should return k = 5,
     *              with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
     * It does not matter what you leave beyond the returned k (hence they are underscores).
     */
    public static int RemoveDuplicates2(int[] nums)
    {
        var n = nums.Length;
        if (n <= 2) return n;

        var j = 0;
        for (var i = 0; i < n; i++)
        {
            if (j < 2 || nums[i] != nums[j - 2])
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }
}
