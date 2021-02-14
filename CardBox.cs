using System;
using System.Collections.Generic;

namespace Monopoly
{
    class CardBox
    {
        private List<ICard> cards;
        private Random random = new Random();

        public CardBox(IEnumerable<ICard> cards)
        {
            this.cards = new List<ICard>(cards);
        }

        public ICard GetCard()
        {
            int randomIndex = random.Next(0, cards.Count);
            return cards[randomIndex];
        }
    }
}
