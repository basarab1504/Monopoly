using System.Collections.Generic;

namespace Monopoly
{
    class CardBox
    {
        private List<ICard> cards;

        public CardBox(IEnumerable<ICard> cards)
        {
            this.cards = new List<ICard>(cards);
        }

        public ICard GetCard()
        {
            return cards[0];
        }
    }
}
