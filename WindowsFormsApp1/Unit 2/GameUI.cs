using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class forms a class interface 
    /// for the RPS Game.
    /// author: Georgia
    /// </summary>
    public partial class GameUI : Form
    {
        RPS_Game game = new RPS_Game();
        public GameUI()
        {
            InitializeComponent();
            
            game.Start("Georgia");
        }

        private void resultForm_Click(object sender, EventArgs e)
        {

        }

        private void loadScissorsImage(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Scissors.jpg");
        }

        private void quitForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paperForm_CheckedChanged(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Paper.jpg");
        }

        private void rockForm_CheckedChanged(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Stone.jpg");
        }

        private void getComputerChoice(object sender, EventArgs e)
        {
            if (scissorsRadioButton.Checked)
            {
                game.PlayerChoice = RPS_Choices.SCISSORS;
            }

            else if (paperRadioButton.Checked) 
            {
                game.PlayerChoice = RPS_Choices.PAPER;
            }

            else if (rockRadioButton.Checked)
            {
                game.PlayerChoice = RPS_Choices.ROCK;
            }

            game.GetComputerChoice();
            showComputerChoice();
            game.WorkoutWinner();
            showResults();
        }

        private void showResults() 
        {
            game.WorkoutWinner();
            resultLabel.Text = "winner = " + game.WinnerName;
            int playerscore = game.PlayerScore;
            int computerscore = game.ComputerScore;
            resultLabel.Text = resultLabel.Text + "\nPlayer Score = " + playerscore;
            resultLabel.Text = resultLabel.Text + "\nComputer Score = " + computerscore;
        }

        private void showComputerChoice() 
        {
            if (game.ComputerChoice == RPS_Choices.ROCK)
            {
                computerPictureBox.Image = Image.FromFile("Stone.jpg");
            }

            else if (game.ComputerChoice == RPS_Choices.PAPER)
            {
                computerPictureBox.Image = Image.FromFile("Paper.jpg");
            }

            else if (game.ComputerChoice == RPS_Choices.SCISSORS) 
            {
                computerPictureBox.Image = Image.FromFile("Scissors.jpg");
            }
        }

        private void gameUI_Load(object sender, EventArgs e)
        {
            RPSsplashscreenForm RPSsplashscreen = new RPSsplashscreenForm();
            RPSsplashscreen.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            RPSsplashscreen.Close();
        }

    }
}
