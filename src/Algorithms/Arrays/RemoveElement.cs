namespace CodingChallengeCollection.Algorithms.Arrays;

public class RemoveElements
{
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
