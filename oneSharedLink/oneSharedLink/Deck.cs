using System;
using System.Collections.Generic;

namespace oneSharedLink
{
    public class Deck
    {
        private List<Card> cards;
        private List<Card> Cards
        {
            get { return cards; }
        }

        public Deck()
        {
            this.cards = new List<Card>();
        }
    }
}
