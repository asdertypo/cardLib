﻿using System;
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
            Console.WriteLine("Club:" + myDeck.Count(Suit.Diamond));
            Console.WriteLine("Club:" + myDeck.Count(Suit.Heart));
            Console.WriteLine("Club:" + myDeck.Count(Suit.Spade));
            Console.ReadKey();
        }
    }
}
