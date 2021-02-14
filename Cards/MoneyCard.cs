namespace Monopoly
{
    class MoneyCard : Card
    {
        public double Amount { get; set; }

        public override void Interact(Player player)
        {
            base.Interact(player);
            System.Console.WriteLine($"{player.Name} получил {Amount}");
            player.Capital += Amount;
        }
    }
}
