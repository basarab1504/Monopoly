using System.Collections.Generic;

namespace Monopoly
{
    class CardCell : Cell
    {
        public CardBox Box { get; set; }

        public override void PlayerStepped(Player player)
        {
            base.PlayerStepped(player);
            var card = Box.GetCard();
            card.Interact(player);
        }
    }
}
