namespace Monopoly
{
    class CircularSinglyLinkedList<T>
    {
        Node head;
        Node tail;

        public Node First => head;

        public void Add(T item)
        {
            var node = new Node();
            node.Value = item;

            if (head == null)
            {
                head = node;
            }
            else if (tail == null)
            {
                tail = node;
                head.Next = tail;
                tail.Next = head;
            }
            else
            {
                tail.Next = node;
                tail = node;
                tail.Next = head;
            }
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }
    }
}
