namespace Monopoly
{
    abstract class Cell : ICell
    {
        public int ID { get; set; }

        public virtual void PlayerStepped(Player player)
        {
            player.Current = this;
            System.Console.WriteLine($"{player.Name} встал на {ID}: {GetType()}");
        }
    }
}
