using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand : IComparable
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }

        public void SortHand()
        {
            CardsInHand.Sort();
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        public int CompareTo(object obj)
        {
            if (obj is Hand)
            {
                Hand otherHand = obj as Hand;
                if (this.TotalHCP > otherHand.TotalHCP) return -1;
                if (this.TotalHCP == otherHand.TotalHCP) return 0;
                else return 1;
            }
            else
            {
                throw new ArgumentException("Object is not a Card");
            }
        }
    }
}