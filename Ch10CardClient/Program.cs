using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10CardLib;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.isAceHigh = true;
            //Card.useTrumps = true;
            //Card.trump = Suit.Spade;
            Card card1 = new Card(Suit.Club, Rank.Eight);
            Card card2 = new Card(Suit.Spade, Rank.King);
            Console.WriteLine("card1>card2:{0}", card1 > card2);
            Console.ReadKey();
        }
    }
}
