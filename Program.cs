using System.Collections.Generic;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            NoInteractionCell cell = new NoInteractionCell();
            GoToJailCell goToJailCell = new GoToJailCell() { JailCell = cell };

            var cells = new Cell[5] { new GoCell(), new PropertyCell() { Label = "Первая", Price = 25000, Rent = 5000 }, new PropertyCell() { Label = "Вторая", Price = 25000, Rent = 5000 }, cell, goToJailCell };
            var players = new Player[] { new Player() { Name = "red" }, new Player() { Name = "dog" } };

            Game game = new Game(players, cells);

            // game.MakeMove(2);
            // game.MakeMove(4);
            // game.MakeMove(4);
            // game.MakeMove(4);
            // game.MakeMove(4);
            // game.MakeMove(4);

            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
        }
    }
}
