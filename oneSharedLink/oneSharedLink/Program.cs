using System;

namespace oneSharedLink
{
    class MainClass
    {
        public const int SymbolsPerCard = 8;

        public static void Main(string[] args)
        {
            Deck deck = new Deck(SymbolsPerCard);

            WriteCards(deck);
        }

        private static void WriteCards(Deck deck)
        {
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine("Card: ");
                foreach (string symbol in card.Symbols)
                {
                    Console.Write(symbol + " ");
                }
            }
        }
    }
}
