using System.Collections.Generic;

namespace Monopoly
{
    class Game
    {
        PlayerQueue queue;
        Board board;
        Dies dies = new Dies();
        public Jail Jail { get; set; }

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

            dies.Roll();

            System.Console.WriteLine($"{currentPlayer.Name} выпало: {dies.First} и {dies.Second}");

            //если выпал дубль
            //если в тюрьме
            //выйти и ходить
            //иначе
            //ходить еще раз
            //иначе
            //если в тюрьме
            //учесть
            //иначе
            //ходить

            if (!currentPlayer.InJail)
                Move(currentPlayer, dies.First + dies.Second);
            else if (dies.First == dies.Second)
                Jail.RemoveFromJail(currentPlayer);
            else
                Jail.Update(currentPlayer);
        }

        public void MakeInstantMove(int distance)
        {
            var currentPlayer = queue.GetCurrentPlayer();
            Move(currentPlayer, distance);
        }

        private void Move(Player currentPlayer, int distance)
        {
            ICell current = currentPlayer.Current;
            ICell final = board.GetNext(currentPlayer.Current, distance);
            final.PlayerStepped(currentPlayer);
        }

    }
}
