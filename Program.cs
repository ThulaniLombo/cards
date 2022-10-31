using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrPlayerScore = new int [5];
            string[] allCards;


            Dictionary<string, int> cardValues = new Dictionary<string, int>();

            cardValues.Add("A", 1);
            cardValues.Add("J", 11);
            cardValues.Add("Q", 12);
            cardValues.Add("K", 13);



            // File name  
            string fileName = @"C:\Users\Mawethw'Abongile\Documents\CodeMaze\Thulaz\cards\bin\Debug\player.txt";
            try
            {
                // Create a StreamReader  
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    int index = 0;

                    // Read line by line  
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] strAllCards = line.Split(':');

                        string card = strAllCards[1];

                        allCards = card.Split(',');
                        int number;
                        bool isNumber;

                        int playerScore = 0;

                        for (int i = 0; i < allCards.Length; i++)
                        {

                            isNumber = int.TryParse((allCards[i][0]).ToString(), out number);

                            if (!isNumber)
                            {
                                number = cardValues[(allCards[i][0]).ToString()];
                            }

                            playerScore += number;

                        }
                        arrPlayerScore[index] = playerScore;

                        index++;
                        //Console.WriteLine(line);
                    }

                    Array.Sort(arrPlayerScore);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
                       
            
            Console.ReadLine();
        }

        public static int[] CheckForTies(int [] arrPlayerScore)
        {
            
        }
    }
}
