using System.Collections.Generic;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            GoToCard card = new GoToCard();
            ICard card2 = new MoneyCard() { Amount = -10000 };

            var cards = new ICard[] { card, card2 };

            CardBox box = new CardBox(cards);

            ICell goToCell = new GoCell();
            ICell cell1 = new PropertyCell() { Label = "Первая", Price = 25000, Rent = 5000 };
            ICell cell2 = new CardCell() { Box = box };
            ICell cell3 = new PropertyCell() { Label = "Вторая", Price = 25000, Rent = 5000 };
            ICell jailCell = new NoInteractionCell();
            ICell goToJailCell = new GoToJailCell() { JailCell = jailCell };

            card.Cell = cell1;

            var cells = new ICell[] { goToCell, cell1, cell2, cell3, jailCell, goToJailCell };
            var players = new Player[] { new Player() { Name = "red" } };

            Game game = new Game(players, cells);

            game.MakeMove();

            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
            // game.MakeMove(5);
            // System.Console.WriteLine(player.Capital);
        }
    }
}
