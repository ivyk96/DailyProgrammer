using System;
using System.Collections.Generic;
using System.Linq;
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
            winnerLabel.Text = game.CheckWinner(this.Controls.OfType<Button>());
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
        }
    }
}