using System;
using System.Collections.Generic;

namespace CodingChallengeCollection.DataStructures
{
    public class SingleLinkedList {
        public ListNode First;
        public ListNode Last;

        public void AddLast(int value)
        {
            var newNode = new ListNode(value);
            if (First == null) {
                First = Last = newNode;
            }
            else
            {
                Last.next = newNode;
                Last = newNode;
            }
        }

        // [10 -> 20 -> 30] => [10 <- 20 <- 30]
        public void Reverse()
        {
            var current = First;
            ListNode prev = null;

            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            Last = First;
            First = prev;
        }

        public List<ListNode> ToList()
        {
            var list = new List<ListNode>();
            var current = First;
            while (current != null)
            {
                list.Add(current);
                current = current.next;
            }
            return list;
        }

        public ListNode KthNodeFromTheEnd(int k)
        {
            return new ListNode(0);
        }

        public ListNode KthNodeFromTheEnd_OnePass(int k)
        {
            var first = First;
            var  second = First;
            var distance = 0;
            while (second is not null)
            {
                if (second == Last)
                    return first;

                second = second.next;
                if (distance == k - 1)
                {
                    first = first.next;
                }
                else
                {
                    distance++;
                }
            }

            throw new Exception("Not found, something went wrong.");
        }
    }

    public class ListNode {

        public int val;
        public ListNode? next;

        public ListNode(int val, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            return $"{val}";
        }

        public static implicit operator ListNode(int[]? values)
        {
            if (values == null || values.Length == 0)
                return null;

            var head = new ListNode(values[0]);
            var current = head;

            for (var i = 1; i < values.Length; i++) {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }
    }
}
