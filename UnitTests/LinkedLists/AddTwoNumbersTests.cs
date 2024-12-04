using CodingChallengeCollection.Algorithms.LinkedLists;
using CodingChallengeCollection.DataStructures;
using Xunit;

namespace CodingChallengeCollection.UnitTests.LinkedLists;

public class AddTwoNumbersTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbers_Test(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = AddTwoNumbers.Run(l1, l2);

        var current = expected;
        while (current != null)
        {
            Assert.NotNull(actual);
            Assert.Equal(current.val, actual.val);
            current = current.next;
            actual = actual.next;
        }
    }

    public static TheoryData<ListNode, ListNode, ListNode> TestData =>
        new()
        {
            {
                new ListNode(2, new ListNode(4, new ListNode(3))),
                new ListNode(5, new ListNode(6, new ListNode(4))),
                new ListNode(7, new ListNode(0, new ListNode(8)))
            },
            {
                new ListNode(0), new ListNode(0), new ListNode(0)
            },
            {
                new[] { 9, 9, 9, 9, 9, 9, 9 },
                new[] { 9, 9, 9, 9 },
                new[] { 8, 9, 9, 9, 0, 0, 0, 1 }
            },
        };
}
