using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        readonly string suit;
        readonly string numeral;
        readonly int value;
        readonly Bitmap cardPicture;

        public Card(string suit, int number)
        {
            this.suit = suit;

            if(number <= 10) {numeral = number.ToString();} 
            if(number == 11) { numeral = "J"; }
            if(number == 12) { numeral = "Q"; }
            if(number == 13) { numeral = "K"; }
            if(number == 14) { numeral = "A"; }

            if (number < 10) { this.value = number; }
            else { this.value = 10; }
        }

        public string GetSuit() { return this.suit; }
        public string GetNumeral() { return this.numeral; }
        public int GetValue() { return this.value; }
    }
}
