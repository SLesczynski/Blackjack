using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class hand
    {
        int lightCount;
        int heavyCount;
        List<card> currentHandCards = new List<card>();
        hand(card card)
        {
            if(card.getNumber() == 0) { }
        }
    }
}
