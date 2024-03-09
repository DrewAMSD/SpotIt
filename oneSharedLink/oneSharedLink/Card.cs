using System;
using System.Collections.Generic;

namespace oneSharedLink
{
    public class Card
    {
        private List<string> symbols;
        public List<string> Symbols
        {
            get { return symbols; }
        }

        public Card()
        {
            this.symbols = new List<string>();
        }
    }
}
