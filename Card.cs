namespace Monopoly
{
    interface ICard
    {
        void Interact(Player player);
    }

    class GoToCard : ICard
    {
        ICell Cell { get; set; }

        public void Interact(Player player)
        {
            Cell.PlayerStepped(player);
        }
    }

    class MoneyCard : ICard
    {
        double Amount { get; set; }

        public void Interact(Player player)
        {
            player.Capital -= Amount;
        }
    }
}
