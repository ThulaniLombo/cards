using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
     class DealCards: DeckofCards
    {
        private Cards[] player1Hand;
        private Cards[] sortedPlayer1Hand;
        private Cards[] player2Hand;
        private Cards[] sortedPlayer2Hand;
        private Cards[] player3Hand;
        private Cards[] sortedPlayer3Hand;
        private Cards[] player4Hand;
        private Cards[] sortedPlayer4Hand;
        private Cards[] player5Hand;
        private Cards[] sortedPlayer5Hand;


        public DealCards()
        {
            player1Hand = new Cards[5];
            sortedPlayer1Hand = new Cards[5];
            player2Hand = new Cards[5];
            sortedPlayer2Hand = new Cards[5];
            player3Hand = new Cards[5];
            sortedPlayer3Hand = new Cards[5];
            player4Hand = new Cards[5];
            sortedPlayer4Hand = new Cards[5];
            player5Hand = new Cards[5];
            sortedPlayer5Hand = new Cards[5];
        }

        public void Deal()
        {
            CreateDeck(); //create the deck of cards and shuffle
            GetHand();
            SortCards();
            DisplayCards();
            EvaluateHands();

        }

        public void GetHand()
        {
            //Give five cards to each player
            for(int i = 0; i < 5; i++)
            {
                player1Hand[i] = GetDeck[i];
            }

            for (int i = 5; i < 10; i++)
            {
                player2Hand[i - 5] = GetDeck[i];
            }

            for (int i = 10; i < 15; i++)
            {
                player3Hand[i - 10] = GetDeck[i];
            }

            for (int i = 15; i < 20; i++)
            {
                player4Hand[i - 15] = GetDeck[i];
            }

            for (int i = 20; i < 25; i++)
            {
                player5Hand[i - 20] = GetDeck[i];
            }
        }

        public void SortCards()
        {

            var queryPlayer1 = from hand in player1Hand
                               orderby hand.Value
                               select hand;
            var queryPlayer2 = from hand in player2Hand
                               orderby hand.Value
                               select hand;
            var queryPlayer3 = from hand in player3Hand
                               orderby hand.Value
                               select hand;
            var queryPlayer4 = from hand in player4Hand
                               orderby hand.Value
                               select hand;
            var queryPlayer5 = from hand in player5Hand
                               orderby hand.Value
                               select hand;

            var index = 0;
            foreach(var element in queryPlayer1.ToList())
            {
                sortedPlayer1Hand[index] = element;
                index++;
            }

             index = 0;
            foreach (var element in queryPlayer2.ToList())
            {
                sortedPlayer2Hand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryPlayer3.ToList())
            {
                sortedPlayer3Hand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryPlayer4.ToList())
            {
                sortedPlayer4Hand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryPlayer5.ToList())
            {
                sortedPlayer5Hand[index] = element;
                index++;
            }
        }
        public void DisplayCards()
        {
            Console.Clear();
            int x = 0;
            int y = 1;

            //display player hand
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Player's hand");
            for(int i = 0; i < 5; i++)
            {
                DrawCard.DrawCardOutline(x, y);
                DrawCard.DrawCardSuitValue(sortedPlayer1Hand[i], x, y);
                x++;
            }

            y = 15;
            x = 0;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for(int i = 5; i < 10; i++)
            {
                DrawCard.DrawCardOutline(x, y);
                DrawCard.DrawCardSuitValue(sortedPlayer2Hand[i - 5], x, y);
                x++;
            }
        }

        public void EvaluateHands()
        {

        }
    }
}
