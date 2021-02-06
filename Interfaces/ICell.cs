namespace Monopoly
{
    interface ICell
    {
        int Index { get; }
        void PlayerStepped(Player player);
    }
}
