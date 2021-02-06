namespace Monopoly
{
    class Player
    {
        public string Name { get; set; }
        public double Capital { get; set; }
        public ICell Current { get; set; }
    }
}
