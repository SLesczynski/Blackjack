using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class card
    {
        string suit;
        int number;
        int value;

        public card(string suit, int number)
        {
            this.suit = suit;
            this.number = number;
            if(number < 10)
            {
                this.value = number;
            } else
            {
                this.value = 10;
            }
        }

        public string getSuit()
        {
            return this.suit;
        }

        public int getNumber()
        {
            return this.number;
        }

        public int getValue()
        {
            return this.value;
        }
    }
}
