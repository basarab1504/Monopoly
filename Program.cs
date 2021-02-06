using System.Collections.Generic;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            ICell goToCell = new GoCell();
            ICell cell1 = new PropertyCell() { Label = "Первая", Price = 25000, Rent = 5000 };
            ICell cell2 = new PropertyCell() { Label = "Вторая", Price = 25000, Rent = 5000 };
            ICell jailCell = new NoInteractionCell();
            ICell goToJailCell = new GoToJailCell() { JailCell = jailCell };

            var cells = new ICell[5] { goToCell, cell1, cell2, jailCell, goToJailCell };
            var players = new Player[] { new Player() { Name = "red" } };

            Game game = new Game(players, cells);

            game.MakeMove(1);
            game.MakeMove(1);
            game.MakeMove(2);

            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
        }
    }
}
