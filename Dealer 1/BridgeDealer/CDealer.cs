using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BridgeDealer
{
    public class CDealer
    {
        private const int playerCount = 4;
        private CDeck cards;
        private CHand[] players;

        public CDealer()
        {
            cards = new CDeck();
            players = new CHand[playerCount]; //initialize the players array.

            for (int i = 0; i < playerCount; i++) //create a new CHand object for all the players in the players array.
                players[i] = new CHand();
        }

        public void Deal(ListBox lb)
        {
            cards.ShuffledHands(players); //shuffles all the players cards.

            lb.Items.Clear();

            for (int i = 0; i < players.Length; i++)
            {
                string spades = "S:\t";
                string hearts = "H:\t";
                string diamonds = "D:\t";
                string clubs = "C:\t";
                string currRank = "";
                lb.Items.Add(((Player)(i)).ToString()); //adds the player position on the table (based on the enumerator)
                lb.Items.Add("");

                for (int j = 0; j < players[i].Hand.Length; j++)
                {
                    switch (players[i].Hand[j].Number)
                    {
                        case CardValue.ACE:
                            currRank = "A";
                            break;
                        case CardValue.TWO:
                            currRank = "2";
                            break;
                        case CardValue.THREE:
                            currRank = "3";
                            break;
                        case CardValue.FOUR:
                            currRank = "4";
                            break;
                        case CardValue.FIVE:
                            currRank = "5";
                            break;
                        case CardValue.SIX:
                            currRank = "6";
                            break;
                        case CardValue.SEVEN:
                            currRank = "7";
                            break;
                        case CardValue.EIGHT:
                            currRank = "8";
                            break;
                        case CardValue.NINE:
                            currRank = "9";
                            break;
                        case CardValue.TEN:
                            currRank = "T";
                            break;
                        case CardValue.JACK:
                            currRank = "J";
                            break;
                        case CardValue.QUEEN:
                            currRank = "Q";
                            break;
                        case CardValue.KING:
                            currRank = "K";
                            break;
                        default:
                            break;
                    }

                    switch (players[i].Hand[j].Suit)
                    {
                        case SuitValue.SPADES:
                            spades += currRank;
                            break;
                        case SuitValue.HEARTS:
                            hearts += currRank;
                            break;
                        case SuitValue.DIAMONDS:
                            diamonds += currRank;
                            break;
                        case SuitValue.CLUBS:
                            clubs += currRank;
                            break;
                        default:
                            break;
                    }
                    
                    //lb.Items.Add(players[i].Hand[j].ToString()); //adds each of the players cards to the list box.
                }
                lb.Items.Add(spades);
                lb.Items.Add(hearts);
                lb.Items.Add(diamonds);
                lb.Items.Add(clubs);
                lb.Items.Add("");
                lb.Items.Add("HCP: " + players[i].TotalPoints().ToString()); //outputs the players high card point score.
                lb.Items.Add("-----------");
            }
        }
    }
}
