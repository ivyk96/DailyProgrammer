using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vsAIMenuItem_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(false);
            game.MdiParent = this;
            game.Show();
        }

        private void vsPlayeMenuItem_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm(true);
            game.MdiParent = this;
            game.Show();
        }
    }
}