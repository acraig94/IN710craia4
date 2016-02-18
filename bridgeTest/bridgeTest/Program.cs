using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridgeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            Hand handN = new Hand();
            deck1.shuffle();


            /*
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck1.DealCard());
                //Console.WriteLine();
                
            }
            */

            // Deals hand
            for (int i = 0; i < 13; i++)
            {
                handN.RecieveCard(i, deck1.DealCard());
            }
            // Prints hand
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine(handN.getCard(i));
            }

            Console.WriteLine("N = " + handN.CalculateHCP());

            Console.ReadLine();

        }
    }
}
