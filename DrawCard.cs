using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    public class DrawCard
    {
        //Draw cards
        public static void DrawCardOutline(int xWidth, int yHeight)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int x = xWidth * 12; //Width
            int y = yHeight; //Height

            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n"); //top edge

            for(int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if(i != 9)
                {
                    Console.WriteLine("|          |"); //Left and right edges
                }
                else
                {
                    Console.WriteLine("|__________|"); //bottom edge of the card
                }
            }
        }

        //Display Suit and value of the card inside its outline
        public static void DrawCardSuitValue(Cards card, int xWidth, int yHeight)
        {
            
            int x = xWidth * 12;
            int y = yHeight;

            //hearts and diamonds are red, clubs and spades are black

            switch (card.Suit)
            {
                case Cards.CardSuit.Hearts:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Cards.CardSuit.Diamonds:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Cards.CardSuit.Clubs:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Cards.CardSuit.Spades:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            //Display value of the card
            Console.SetCursorPosition(x + 5, y + 5);
            Console.Write(card.Suit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.Value);
        }
    }
}
