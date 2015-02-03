using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10CardLib
{
    //public class Deck
    //{
    //    private Card[] cards;
    
    //    public Deck()
    //    {
    //        //throw new System.NotImplementedException();
    //        cards = new Card[52];
    //        for (int i = 0; i < 4; i++)
    //        {
    //            for (int j = 1; j < 14; j++)
    //            {
    //                cards[13*i + j-1] = new Card((Suit)i, (Rank)j);
    //            }
    //        }
    //    }

    //    public Card GetCard(int cardNum)
    //    {
    //        //throw new System.NotImplementedException();
    //        if (cardNum >= 0 && cardNum < 52)
    //            return cards[cardNum];
    //        else
    //            throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
    //    }

    //    public void Shuffle()//洗牌
    //    {
    //        //throw new System.NotImplementedException();
    //        Card[] newDest = new Card[52];
    //        int[] point=new int[52];
    //        for(int i=0;i<52;i++)
    //            point[i]=i;
    //        Random sourceGen = new Random();
    //        for (int i = 0; i < 52; i++)
    //        { 
    //            int destCard=0;
    //            destCard = sourceGen.Next(0, 52 - i);
    //            newDest[i] = cards[point[destCard]];
    //            for (int j = destCard; j < 51; j++)
    //                point[j] = point[j + 1];
    //        }
    //        newDest.CopyTo(cards, 0);
    //    }
    //    public int Count(Suit newSuit)
    //    {
    //        int val = 0;
    //        for (int i = 0; i < 52; i++)
    //        {
    //            if (cards[i].suit == newSuit)
    //                val++;
    //        }
    //        return val;
    //    }
    //}
    public class Deck
    { 
        
    }
}
