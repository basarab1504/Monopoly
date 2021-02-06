using System;
using System.Collections.Generic;

namespace Monopoly
{
    class Game
    {
        PlayerQueue queue;
        Board board;

        public Game(IEnumerable<Player> players, IEnumerable<ICell> cells)
        {
            this.board = new Board(cells);
            queue = new PlayerQueue(players);
            foreach (var item in players)
                item.Current = board.First;
        }

        public void MakeMove(int distance)
        {
            var currentPlayer = queue.GetCurrentPlayer();

            ICell current = currentPlayer.Current;
            ICell final = board.GetNext(currentPlayer.Current, distance);

            final.PlayerStepped(currentPlayer);
        }

        public void MakeMove()
        {
            int distance = new Random().Next(1, 13);
            MakeMove(distance);
        }
    }
}
