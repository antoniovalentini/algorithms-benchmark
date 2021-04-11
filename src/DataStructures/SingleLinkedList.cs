using System;
using System.Collections.Generic;

namespace CodingChallengeCollection.DataStructures
{
    public class SingleLinkedList {
        public Node First;
        public Node Last;

        public void AddLast(int value)
        {
            var newNode = new Node(value);
            if (First == null) {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
        }

        // [10 -> 20 -> 30] => [10 <- 20 <- 30]
        public void Reverse()
        {
            var current = First;
            Node prev = null;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Last = First;
            First = prev;
        }

        public List<Node> ToList()
        {
            var list = new List<Node>();
            var current = First;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public Node KthNodeFromTheEnd(int k)
        {
            return new Node(0);
        }

        public Node KthNodeFromTheEnd_OnePass(int k)
        {
            var first = First;
            var  second = First;
            var distance = 0;
            while (second is not null)
            {
                if (second == Last)
                    return first;

                second = second.Next;
                if (distance == k - 1)
                {
                    first = first.Next;
                }
                else
                {
                    distance++;
                }
            }

            throw new Exception("Not found, something went wrong.");
        }
    }

    public class Node {

        public int Value;
        public Node Next;

        public Node(int value) {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
