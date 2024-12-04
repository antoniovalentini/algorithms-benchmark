using CodingChallengeCollection.DataStructures;

namespace CodingChallengeCollection.Algorithms.LinkedLists;

/// <summary>
/// You are given two non-empty linked lists representing two non-negative integers.
/// The digits are stored in reverse order, and each of their nodes contains a single digit.
/// Add the two numbers and return the sum as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// <para />
/// Example 1:
/// /// <list>
/// <item>Input: l1 = [2,4,3]</item>
/// <item>Input: l2 = [5,6,4]</item>
/// <item>Output:     [7,0,8]</item>
/// <item>Explanation: 342 + 465 = 807.</item>
/// </list>
/// Constraints:
/// <list type="bullet">
/// <item>The number of nodes in each linked list is in the range [1, 100].</item>
/// <item>0 &lt;= Node.val &lt;= 9</item>
/// <item>It is guaranteed that the list represents a number that does not have leading zeros.</item>
/// </list>
/// </summary>
public static class AddTwoNumbers
{
    public static ListNode Run(ListNode l1, ListNode l2)
    {
        var carry = 0;
        ListNode? head = null;
        ListNode? current = null;

        while (l1 is not null || l2 is not null || carry > 0)
        {
            var value = carry;
            if (l1 is not null)
            {
                value += l1.val;
                l1 = l1.next;
            }
            if (l2 is not null)
            {
                value += l2.val;
                l2 = l2.next;
            }

            if (value >= 10)
            {
                carry = 1;
                value %= 10;
            }
            else
            {
                carry = 0;
            }

            if (head is null)
            {
                head = new ListNode(value);
                current = head;
            }
            else
            {
                current!.next = new ListNode(value);
                current = current.next;
            }
        }

        return head!;
    }
}
