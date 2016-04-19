using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class Form1 : Form
    {
        private GameFactory game = new GameFactory();
        private AIFactory ai;

        public Form1()
        {
            InitializeComponent();
            ai = new AIFactory(game);
            turnLabel.Text = game.GetTurn();
            winnerLabel.Text = "";
        }

        private void AI_Click()
        {
            Button b = ai.Turn(Controls.OfType<Button>());

            if (b != null)
            {
                turnLabel.Text = game.PlayTurn(b);
                winnerLabel.Text = game.CheckWinner(this.Controls.OfType<Button>());
                winXLabel.Text = game.XWins.ToString();
                winOLabel.Text = game.OWins.ToString();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            turnLabel.Text = game.PlayTurn((Button)sender);
            winnerLabel.Text = game.CheckWinner(this.Controls.OfType<Button>());
            winXLabel.Text = game.XWins.ToString();
            winOLabel.Text = game.OWins.ToString();
            AI_Click();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            foreach(Button b in Controls.OfType<Button>())
            {
                if((string)b.Tag == "field")
                {
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            turnLabel.Text = game.ResetTurn();
            winnerLabel.Text = "";
        }
    }
}