using System;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class Form1 : Form
    {
        private int turn = 0;

        public Form1()
        {
            InitializeComponent();
            turnLabel.Text = "";
            winnerLabel.Text = "";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(turn == 0)
            {
                button.Text = "X";
                button.Enabled = false;
                turn++;
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
                turn--;
            }

            Check_Winner();
        }

        public void Check_Winner()
        {
            //Horizontal checks
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
        }
    }
}