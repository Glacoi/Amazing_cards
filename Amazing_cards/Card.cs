using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazing_cards
{
    public class Card
    {
        private string suit;
        private int value;

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public string GetSuit()
        {
            return suit;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
