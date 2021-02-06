using System.Collections.Generic;

namespace Monopoly
{
    class PlayerQueue
    {
        Queue<Player> players = new Queue<Player>();

        public PlayerQueue(IEnumerable<Player> players)
        {
            this.players = new Queue<Player>(players);
        }

        public Player Peek()
        {
            return players.Peek();
        }

        public Player GetCurrentPlayer()
        {
            var player = players.Dequeue();
            players.Enqueue(player);
            return player;
        }

        public void Enqueue(Player player)
        {
            players.Enqueue(player);
        }

        public Player Dequeue()
        {
            return players.Dequeue();
        }
    }
}
