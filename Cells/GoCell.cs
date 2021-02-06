namespace Monopoly
{
    class GoCell : Cell
    {
        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            player.Capital += 200000;
        }
    }
}
