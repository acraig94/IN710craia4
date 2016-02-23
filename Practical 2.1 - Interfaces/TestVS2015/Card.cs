using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVS2015
{
    public enum SuitValue : int
    {
        Spades, Hearts, Diamonds, Clubs
    }

    public enum RankValue : int
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }

    // Note the different ways to use the Property (get;set;) synntax feature
    public class Card : IComparable
    {
        // A read-write Property
        public SuitValue Suit {  get; set;}

        // A read-only Property
        private string shortRank;
        public String ShortRank
        {
            get
            {
                return shortRank;
            }
        }
        // ShortRankValue
        private int shortRankValue;
        public int ShortRankValue
        {
            get
            {
                return shortRankValue;
            }
        }

        // A Property with logic on write (set)
        private RankValue rank;
        public RankValue Rank
        {
            get
            {
                return rank;
            }
 
            set
            {
                rank = value;
                switch (rank)
                {
                    case RankValue.Ace:
                        shortRank = "A";
                        shortRankValue = 14;
                        break;
                    case RankValue.King:
                        shortRank = "K";
                        shortRankValue = 13;
                        break;
                    case RankValue.Queen:
                        shortRank = "Q";
                        shortRankValue = 12;
                        break;
                    case RankValue.Jack:
                        shortRank = "J";
                        shortRankValue = 11;
                        break;
                    case RankValue.Ten:
                        shortRank = "T";
                        shortRankValue = 10;
                        break;
                    default:
                        int rankOrdinalPosition = (int)rank;
                        shortRank = (rankOrdinalPosition + 2).ToString();
                        shortRankValue = rankOrdinalPosition + 2;
                        break;
                } // end switch
            } // end set
        }



        public int HCP
        {
            get; set;
        }

        public Card(SuitValue initSuit, RankValue initRank)
        {
            Suit = initSuit;
            Rank = initRank;

            HCP = 0;
            switch(Rank)
            {
                case RankValue.Ace:
                    HCP = 4;
                    break;
                case RankValue.King:
                    HCP = 3;
                    break;
                case RankValue.Queen:
                    HCP = 2;
                    break;
                case RankValue.Jack:
                    HCP = 1;
                    break;
            }

        }

        public override string ToString()
        {
            return (Rank.ToString() + " of " + Suit.ToString());
        }

        public int CompareTo(object obj)
        {
            if (obj is Card)
            {
                Card otherCard = obj as Card;
                if (this.ShortRankValue > otherCard.ShortRankValue) return -1;
                if (this.ShortRankValue == otherCard.ShortRankValue) return 0;
                else return 1;
            }
            else
            {
                throw new ArgumentException("Object is not a Card");
            }
        }
    }
}
