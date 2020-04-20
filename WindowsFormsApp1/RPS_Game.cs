using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class runs the game
    /// The computer chooses a number, and so does the user
    /// Depending on the outcome a number will be added
    /// At the end of the game, the winner will be displayed
    /// with the appropriate symbol.
    /// Author: Georgia
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public string PlayerName { get; set; }
        //public string ComputerName { get; set; }
        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random();

        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }

        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";
        }

        /// <summary>
        /// *******************************************************
        /// Ends the game
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// *******************************************************
        /// Computer chooses a number between 1-3
        /// *******************************************************
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else ComputerChoice = RPS_Choices.SCISSORS;
        
    }

         /// <summary>
        /// *******************************************************
        /// This will dertemine whether the computer has won / drawn
        /// or the player has won / drawn
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)

            {
                WinnerName = "Draw!!!";
                PlayerScore++;
                ComputerScore++;
            }
            else if (PlayerChoice == RPS_Choices.ROCK &&
                   ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER &&
                    ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.SCISSORS &&
                    ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.ROCK &&
                     ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER &&
                     ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.SCISSORS &&
                    ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;

            }

        }

        /// <summary>
        /// The scores are compared, the result is shown with an image.
        /// </summary>

        public void CheckGameWinner() 
        {
            if (PlayerScore > ComputerScore)
            {
                
               
                WinnerName = PlayerName;
            }

            else if (PlayerScore < ComputerScore)
            {
                
            WinnerName = COMPUTER_NAME;
            }

            else 
            {
               
            WinnerName = "Draw";

            }
        }
     }
  }

        
    


