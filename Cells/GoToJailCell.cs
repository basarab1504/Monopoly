namespace Monopoly
{
    class GoToJailCell : Cell
    {
        public Jail Jail { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            Jail.PutInJail(player);
        }
    }
}
