using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    public enum Hand
    {
        Nothing,
        OnePair,
        TwoPairs,
        ThreeKind,
        Straight,
        Flush,
        FullHouse,
        FourKind
    }

    public struct HandValue
    {
        public int Total { get; set; }
        public int HighCard { get; set; }
    }
    public class HandEvaluator : Cards
    {
        private int heartsSum;
        private int diamondSum;
        private int clubSum;
        private int spadesSum;

        private Cards[] cards;
        private HandValue handValue;

        public HandEvaluator(Cards[] sortedHand)
        {
            heartsSum = 0;
            diamondSum = 0;
            clubSum = 0;
            spadesSum = 0;  
            cards = new Cards[5];
            handValue = new HandValue();
        }

        private HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }
        }

        public Cards[] card
        {
            get { return card; }
            set
            {
                card[0] = value[0];
                card[1] = value[1];
                card[2] = value[2];
                card[3] = value[3];
                card[4] = value[4];
            }
        }

        //public void EvaluateHand()
        //{
        //    //get the number of each suit on hand
        //    getNumberOfSuit();
        //}

        //private void getNumberOfSuit()
        //{
        //    foreach(var element in Cards)
        //    {
        //        if(element.Suit == Cards.CardSuit.Hearts)
        //        {
        //            heartsSum++;
        //        }else if(element.Suit == Cards.CardSuit.Diamonds)
        //        {
        //            diamondSum++;
        //        }else if(element.suit == Cards.CardSuit.Clubs)
        //        {
        //            clubSum++;
        //        }else if(element.suit == Cards.CardSuit.Spades)
        //        {
        //            spadesSum++;
        //        }
        //    }
        //}
    }
}
