using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Hand
    {
        int lightCount;
        int heavyCount;
        List<Card> currentHandCards = new List<Card>();
        Hand(Card card)
        {
            currentHandCards.Add(card);
        }

        public void addCard(Card card)
        {
            currentHandCards.Add(card);
            if (card.getNumber() == 14)
            {
                lightCount++;
                heavyCount += 11;
            }
            else
            {
                lightCount += card.getValue();
                heavyCount += card.getValue();
            }
        }

        public int getLightCount() { return lightCount; }
        public int getHeavyCount() { return heavyCount; }
        public List<Card> getCurrentHandCards() { return currentHandCards; }
    }
}
