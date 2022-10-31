using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    public class DeckofCards: Cards
    {
        const int numberOfCards = 52; //total number of cards
        private Cards[] deck; //array of all playing cards

        public DeckofCards()
        {
            deck = new Cards[numberOfCards];
        }

        //get current deck
        public Cards[] GetDeck { get { return deck; } }

        //create deck of 52 cards: 13 values each and 4 suits
        public void CreateDeck()
        {
            int i = 0;
            
            foreach(CardSuit s in Enum.GetValues(typeof(CardSuit)))
            {
                foreach(CardValue v in Enum.GetValues(typeof(CardValue)))
                {
                    deck[i] = new Cards {Suit = s, Value = v};
                    i++;
                }
            }
            ShuffleCards();
        }

        //Shuffle cards
        public void ShuffleCards()
        {
            Random random = new Random();
            Cards temp; //temporal card

            //Shuffle cards 20 times
            for(int shuffle = 0; shuffle < 20; shuffle++)
            {
                for(int i = 0; i < numberOfCards; i++)
                {
                    //swap cards
                    int secondCardIndex = random.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }  
            }    
        }
    }
}
