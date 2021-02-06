namespace Monopoly
{
    abstract class Cell : ICell
    {
        private static int index;

        public int Index { get; private set; }

        protected Cell()
        {
            Index = index;
            index++;
        }

        public virtual void PlayerStepped(Player player)
        {
            player.Current = this;
            System.Console.WriteLine($"{player.Name} встал на {GetType()}");
        }
    }
}
