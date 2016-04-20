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

        private void CloseChildForms()
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vsAIMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            GameForm game = new GameForm(false, " vs. AI");
            game.MdiParent = this;
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
        }

        private void vsPlayeMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            GameForm game = new GameForm(true, " vs. Player");
            game.MdiParent = this;
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
        }
    }
}