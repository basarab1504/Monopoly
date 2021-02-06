using System.Collections.Generic;

namespace Monopoly
{
    class Board
    {
        List<ICell> cells = new List<ICell>();

        public ICell First => cells[0];

        public Board(IEnumerable<ICell> cells)
        {
            this.cells = new List<ICell>(cells);
        }

        public ICell GetNext(ICell currentCell, int distance)
        {
            int finalIndex = (currentCell.Index + distance) % cells.Count;
            return cells[finalIndex];
        }
    }
}
