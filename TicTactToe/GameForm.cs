using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class GameForm : Form
    {
        private GameFactory game = new GameFactory();
        private SmartAI ai;

        public GameForm(bool multiplayer, string title)
        {
            InitializeComponent();
            Initialize(multiplayer, title);
        }

        private void Initialize(bool multiplayer, string title)
        {
            if (!multiplayer)
                ai = new SmartAI();
            this.Text += title;
            turnLabel.Text = game.GetTurn();
            winnerLabel.Text = "";

            game.Board = new State[3][];

            for (int i = 0; i < 3; i++)
            {
                game.Board[i] = new State[3];
            }
        }

        private void AI_Click()
        {
            // RandomAI turn
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
            // Player turn with an AI turn.
            turnLabel.Text = game.PlayTurn((Button)sender);
            winnerLabel.Text = game.CheckWinner(this.Controls.OfType<Button>());
            winXLabel.Text = game.XWins.ToString();
            winOLabel.Text = game.OWins.ToString();

            if (ai != null && winnerLabel.Text == "")
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