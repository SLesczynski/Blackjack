using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        int lightCount;
        int heavyCount;
        List<Card> currentHandCards = new List<Card>();
        public Hand()
        {
            lightCount = 0;
            heavyCount = 0;
        }

        public void AddCard(Card card)
        {
            currentHandCards.Add(card);
            if (card.GetNumber() == 14)
            {
                lightCount++;
                heavyCount += 11;
            }
            else
            {
                lightCount += card.GetValue();
                heavyCount += card.GetValue();
            }
        }

        public int GetLightCount() { return lightCount; }
        public int GetHeavyCount() { return heavyCount; }
        public List<Card> GetCurrentHandCards() { return currentHandCards; }
    }
}
