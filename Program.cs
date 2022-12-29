using System;

namespace PassThePigs
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Welcomes players and asks how many players is joining
            Console.WriteLine("Welcome to play Pass The Pigs! How many players are playing the game? 4 players is the maximum!");
            int howManyPlayers = Convert.ToInt32(Console.ReadLine());
            while (howManyPlayers > 4 || howManyPlayers < 2)
            {
                Console.WriteLine("There can be 2-4 players. Enter the allowed amount!");
                howManyPlayers = Convert.ToInt32(Console.ReadLine());
            }

            // Makes Player Array long as many players joining
            Player[] players = new Player[howManyPlayers];

            // Name players
            for (int i = 1; i <= howManyPlayers; i++)
            {
                Console.WriteLine("Give player " + i + " a name.");
                string name = Console.ReadLine();
                players[i-1] = new Player(name);
            }

            // Players play game till winner is found (100 or over points)
            // while (points <= 100)
            //{
                
            
                // While (player wants to continue or lose his turn)
                foreach (Player player in players)
                {
                    Console.WriteLine("Player " + player.name);
                    player.UseTurn();
                }
            //}
        }
    }
}