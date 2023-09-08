using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        readonly string suit;
        readonly int number;
        readonly int value;

        public Card(string suit, int number)
        {
            this.suit = suit;
            this.number = number;
            if (number < 10)
            {
                this.value = number;
            }
            else
            {
                this.value = 10;
            }
        }

        public string GetSuit()
        {
            return this.suit;
        }

        public int GetNumber()
        {
            return this.number;
        }

        public int GetValue()
        {
            return this.value;
        }
    }
}
