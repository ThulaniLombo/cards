using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    public class Player
    {
        public string[] playerName;
        public int numberOfPlayers;

        public void GetPlayers()
        {
            Console.Write("Please enter number of players: ");
            numberOfPlayers = int.Parse(Console.ReadLine());
            Console.Clear();

            playerName = new string[numberOfPlayers];
            
            for(int i = 0; i < playerName.Length; i++)
            {
                Console.Write("Please Enter Player Name {0}: ", i+1);
                playerName[i] = Console.ReadLine();
            }            
            
        }

    }
}
