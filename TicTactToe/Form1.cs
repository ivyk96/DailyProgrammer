using System;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class Form1 : Form
    {
        private GameFactory game = new GameFactory();

        public Form1()
        {
            InitializeComponent();
            turnLabel.Text = game.GetTurn();
            winnerLabel.Text = "";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            turnLabel.Text = game.PlayTurn((Button)sender);
            Check_Winner();
        }

        public void Check_Winner()
        {
            //Horizontal checks
            // X
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            else if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            else if (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            // O
            else if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
            else if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
            else if (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }

            //Vertical checks
            // X
            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            else if (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            else if (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            // O
            else if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
            else if (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
            else if (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }

            //Diagonal checks
            // X
            if (A1.Text == "X" && B2.Text == "X" && C3.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            else if (A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                winnerLabel.Text = "X wins!";
            }
            // O
            else if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
            else if (A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
            {
                winnerLabel.Text = "O wins!";
            }
        }
    }
}