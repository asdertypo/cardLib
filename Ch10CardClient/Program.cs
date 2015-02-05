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
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                    Console.Write(",");
                else
                    Console.WriteLine();
            }
            Console.WriteLine("Club:" + myDeck.Count(Suit.Club));
            Console.WriteLine("Diamond:" + myDeck.Count(Suit.Diamond));
            Console.WriteLine("Heart:" + myDeck.Count(Suit.Heart));
            Console.WriteLine("Spade:" + myDeck.Count(Suit.Spade));
            Console.WriteLine();

            ////copy test
            //Cards test1 = new Cards();
            //Cards test2 = new Cards();
            //test1.Add(new Card((Suit)2, (Rank)12));
            //test2.Add(new Card((Suit)1, (Rank)11));
            //test1.CopyTo(test2);
            //test1[0] = new Card((Suit)3, (Rank)10);
            //Console.WriteLine("test1 value:{0}", test1[0].ToString());
            //Console.WriteLine("test2 value:{0}", test2[0].ToString());
            //Console.ReadKey();
        }
    }
}
