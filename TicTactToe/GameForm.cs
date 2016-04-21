using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class GameForm : Form
    {
        private GameFactory game;

        public GameForm(GameFactory game, string title)
        {
            InitializeComponent();
            Initialize(game, title);
        }

        private void Initialize(GameFactory game, string title)
        {
            this.game = game;
            this.Text += title;
            turnLabel.Text = game.GetTurn();
            winnerLabel.Text = "";
        }

        private void AI_Click()
        {
            // RandomAI turn
            Button b = game.ai.Turn(Controls.OfType<Button>());

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
            // Player turn with an AI turn.
            turnLabel.Text = game.PlayTurn((Button)sender);
            winnerLabel.Text = game.CheckWinner(this.Controls.OfType<Button>());
            winXLabel.Text = game.XWins.ToString();
            winOLabel.Text = game.OWins.ToString();

            if (game.ai != null && winnerLabel.Text == "")
                AI_Click();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            // Restarts the game.
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