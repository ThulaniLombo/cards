using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cards
{
    public class Cards
    {
        //Properties
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }

        public enum CardSuit
        {
            Spades = '♠',
            Hearts = '♥',
            Diamonds = '♦',
            Clubs = '♣'
        }

        public enum CardValue
        {
            ace = 1,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king
        }
    }
}
