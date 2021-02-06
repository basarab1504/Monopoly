using System.Collections.Generic;

namespace Monopoly
{
    class Board
    {
        private CircularSinglyLinkedList<ICell> list = new CircularSinglyLinkedList<ICell>();

        public Board(IEnumerable<ICell> cells)
        {
            foreach (var item in cells)
                list.Add(item);
        }

        public ICell First => list.First.Value;

        public ICell GetNext(ICell cell, int distance)
        {
            var node = list.First;
            while (distance > 0)
                node = node.Next;
            return node.Value;
        }
    }
}
