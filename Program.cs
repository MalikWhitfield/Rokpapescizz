using System;
using System.Collections.Generic;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerChoice;
            bool won = false;
            Dictionary<string, char> myDictionary = new Dictionary<string, char>();
            Console.WriteLine("Let's play Rock Paper Scizz");
            Console.WriteLine("Choose between rock, paper or scizz.");
            string playerChoice = Console.ReadLine();
            // myDictionary.Add("rock", 'a');
            // myDictionary.Add("paper", 'b');
            // myDictionary.Add("scizz", 'c');
            Random rnd = new Random();
            computerChoice = rnd.Next(1, 4);
            while (!won)
            {
                if (computerChoice == 1)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie. Play again.");
                        playerChoice = Console.ReadLine();
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win! Winner Winner!");
                        won = true;
                    }
                    else if (playerChoice == "scizz")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You LOST! LOSER! Play again.");
                        playerChoice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Type rock, paper or scizz.");
                    }
                }
                else if (computerChoice == 2)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("YOU LOSE! LOSER!");
                        playerChoice = Console.ReadLine();
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("That will be a tie");
                        playerChoice = Console.ReadLine();
                    }
                    else if (playerChoice == "scizz")
                    {
                        Console.WriteLine("The computer chose paper.");
                        Console.WriteLine("YOU WIN! WINNER!");
                        won = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Type rock, paper or scizz.");
                    }
                }
                else if (computerChoice == 3)
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computar chose scizz");
                        Console.WriteLine("YOU WIN! WINNER!");
                        won = true;
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scizz.");
                        Console.WriteLine("You got cut open! You Lose!");
                        playerChoice = Console.ReadLine();

                    }
                    else if (playerChoice == "scizz")
                    {
                        Console.WriteLine("The computer chose scizz.");
                        Console.WriteLine("That will be a sharp tie.");
                        playerChoice = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Type rock, paper or scizz.");
                    }
                }
            }
        }
    }
}