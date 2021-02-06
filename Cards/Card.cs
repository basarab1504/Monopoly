namespace Monopoly
{
    class Card : ICard
    {
        public virtual void Interact(Player player)
        {
            System.Console.WriteLine($"{player.Name} взял карту {GetType()}");
        }
    }
}
