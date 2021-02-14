using System.Collections.Generic;

namespace Monopoly
{
    class Jail
    {
        private Dictionary<Player, int> turnsBeforeLeaving = new Dictionary<Player, int>();
        public int TurnsToStay { get; set; }
        public ICell JailCell { get; set; }

        public void PutInJail(Player player)
        {
            turnsBeforeLeaving.Add(player, TurnsToStay);
            JailCell.PlayerStepped(player);
            player.InJail = true;
        }

        public void RemoveFromJail(Player player)
        {
            turnsBeforeLeaving.Remove(player);
            player.InJail = false;
        }

        public void Update(Player player)
        {
            if (turnsBeforeLeaving.ContainsKey(player))
            {
                turnsBeforeLeaving[player]--;
                var howMuchToStay = turnsBeforeLeaving[player];
                if (howMuchToStay <= 0)
                    RemoveFromJail(player);
            }
        }
    }
}
