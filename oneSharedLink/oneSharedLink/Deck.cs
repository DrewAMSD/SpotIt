using System;
using System.Collections.Generic;

namespace oneSharedLink
{
    public class Deck
    {
        private readonly int SymbolsPerCard;

        private List<Card> cards;
        public List<Card> Cards
        {
            get { return cards; }
        }

        public Deck(int symbolsPerCard)
        {
            this.cards = new List<Card>();
            this.SymbolsPerCard = symbolsPerCard;
        }

        public void Init()
        {
            for (int i = 0; i < Math.Pow(SymbolsPerCard - 1, 2) + SymbolsPerCard; i++)
            {
                cards.Add(new Card());
            }
            AddValuesToCards();
        }

        private void AddValuesToCards()
        {
            List<string> AllSymbols = GetSymbols();
            int n = SymbolsPerCard - 1;

        }

        private List<string> GetSymbols()
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= Math.Pow(SymbolsPerCard - 1, 2) + SymbolsPerCard; i++)
            {
                list.Add(""+i+"");
            }
            return list;
        }
    }
}
