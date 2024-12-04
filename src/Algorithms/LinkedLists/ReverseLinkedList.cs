using CodingChallengeCollection.DataStructures;

namespace CodingChallengeCollection.Algorithms.LinkedLists;

public static class ReverseLinkedList
{
    public static ListNode Run(ListNode head)
    {
        ListNode? previous = null;
        ListNode? next;

        var current = head;
        while (current is not null)
        {
            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }
}
