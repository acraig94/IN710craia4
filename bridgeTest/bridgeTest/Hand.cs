using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridgeTest
{
    class Hand
    {

        private const int MAX_CARDS = 13;

        private Card[] cards;


        public Hand()
        {
            cards = new Card[MAX_CARDS];
        }

        public void RecieveCard(int i, Card card)
        {
            cards[i] = card;
        }

        public Card getCard(int i)
        {
            return cards[i];
        }

        public int CalculateHCP()
        {
            int HCP = 0;
            for (int i = 0; i < MAX_CARDS; i++)
            {
                switch (cards[i].getRank())
                {
                    case 11:
                        HCP += 1;
                        break;
                    case 12:
                        HCP += 2;
                        break;
                    case 13:
                        HCP += 3;
                        break;
                    case 14:
                        HCP += 4;
                        break;
                    default:
                        HCP += 0;
                        break;
                }
            }
            return HCP;
        }

    }
}
