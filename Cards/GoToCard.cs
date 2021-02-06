namespace Monopoly
{
    class GoToCard : Card
    {
        public ICell Cell { get; set; }

        public override void Interact(Player player)
        {
            base.Interact(player);
            System.Console.WriteLine($"{player.Name} идет на {Cell.Index}");
            Cell.PlayerStepped(player);
        }
    }
}
