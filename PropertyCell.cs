namespace Monopoly
{
    class PropertyCell : Cell
    {
        public string Label { get; set; }
        public Player Owner { get; set; }
        public double Price { get; set; }
        public double Rent { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            if (Owner != null)
            {
                if (Owner != player)
                {
                    System.Console.WriteLine($"{player.Name} заплатил {Rent}");
                    player.Capital -= Rent;
                }
                else
                {
                    // System.Console.WriteLine("Желаете продать улицу?");
                    // string answer = System.Console.ReadLine();
                    // if (answer == "y")
                    //     Owner = player;
                }
            }
            else
            {
                // System.Console.WriteLine("Желаете купить улицу?");
                // string answer = System.Console.ReadLine();
                // if (answer == "y")
                //     Owner = player;
                System.Console.WriteLine($"{player.Name} купил {Label}");
                Owner = player;
            }
        }
    }
}
