using System;
using System.Collections.Generic;

namespace Monopoly
{
    class Game
    {
        PlayerQueue queue;
        Board board;

        private bool IsOver => queue.Peek() == null;

        public Game(IEnumerable<Player> players, IEnumerable<ICell> cells)
        {
            this.board = new Board(cells);
            queue = new PlayerQueue(players);

            foreach (var item in players)
                item.Current = board.First;
        }

        public void MakeMove()
        {
            var currentPlayer = queue.GetCurrentPlayer();
            RollAndMove(currentPlayer);
        }

        public void MakeMove(int distance)
        {
            var currentPlayer = queue.GetCurrentPlayer();
            Move(currentPlayer, distance);
        }

        private void RollAndMove(Player player)
        {
            int firstDice;
            int secondDice;
            RollDice(out firstDice, out secondDice);
            System.Console.WriteLine($"У {player.Name} выпало {firstDice} и {secondDice}");

            Move(player, firstDice + secondDice);

            if (firstDice == secondDice)
            {
                System.Console.WriteLine($"Дубль у {player.Name}");
                RollAndMove(player);
            }
        }

        private void Move(Player player, int distance)
        {
            ICell current = player.Current;
            ICell final = board.GetNext(player.Current, distance);

            final.PlayerStepped(player);
        }


        private void RollDice(out int first, out int second)
        {
            Random rand = new Random();

            first = rand.Next(1, 7);
            second = rand.Next(1, 7);
        }
    }
}
