using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridgeTest
{
    class Deck
    {

        private const int NUM_CARDS = 52;

        private Card[] deck;
        private int currentCard;
        private Random ranNum;

        public Deck()
        {
            int[] rank = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };

            deck = new Card[NUM_CARDS];
            currentCard = 0;
            ranNum = new Random();
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(rank[i % 13], suits[i / 13]);
            }
        }

        public void shuffle()
        {
            currentCard = 0;
            for (int i = 0; i < deck.Length; i++)
            {
                int j = ranNum.Next(NUM_CARDS);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }


    }
}
