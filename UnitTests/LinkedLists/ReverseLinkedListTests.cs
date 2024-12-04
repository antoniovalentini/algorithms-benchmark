using CodingChallengeCollection.Algorithms.LinkedLists;
using CodingChallengeCollection.DataStructures;
using Xunit;

namespace CodingChallengeCollection.UnitTests.LinkedLists;

public class ReverseLinkedListTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbers_Test(ListNode head, ListNode expected)
    {
        var actual = ReverseLinkedList.Run(head);

        var current = expected;
        while (current != null)
        {
            Assert.NotNull(actual);
            Assert.Equal(current.val, actual.val);
            current = current.next;
            actual = actual.next;
        }
    }

    public static TheoryData<ListNode, ListNode> TestData =>
        new()
        {
            {
                new[] { 1,2,3,4,5 },
                new[] { 5,4,3,2,1 }
            },
            {
                new[] { 1,2 },
                new[] { 2,1 }
            },
            {
                System.Array.Empty<int>(),
                System.Array.Empty<int>()
            },
        };
}
