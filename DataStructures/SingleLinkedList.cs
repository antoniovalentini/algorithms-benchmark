using System.Collections.Generic;

namespace CodingChallengeCollection.DataStructures
{
    internal class SingleLinkedList {
        public Node First;
        public Node Last;

        internal void AddLast(int value)
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
    }

    internal class Node {

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
