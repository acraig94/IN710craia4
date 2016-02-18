using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridgeTest
{
    class Card
    {
        private int rank;
        private string suit;

        public Card(int cardRank, string cardSuit)
        {
            rank = cardRank;
            suit = cardSuit;
        }

        public int getRank()
        {
            return rank;
        }

        public override string ToString()
        {
            string value = "";
            switch (rank)
            {
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                case 14:
                    value = "Ace";
                    break;
                default:
                    value = rank.ToString();
                    break;
            }
            return value + " of " + suit;
        }

    }
}
