namespace Monopoly
{
    class GoToJailCell : Cell
    {
        public ICell JailCell { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            JailCell.PlayerStepped(player);
        }
    }
}
