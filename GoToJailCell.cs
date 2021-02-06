namespace Monopoly
{
    class GoToJailCell : Cell
    {
        public Cell JailCell { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            JailCell.PlayerStepped(player);
        }
    }
}
