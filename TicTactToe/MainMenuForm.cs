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

        private void vsPlayerMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            GameForm game = new GameForm(new GameFactory(), " vs. Player");
            game.MdiParent = this;
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
        }

        private void easyAIMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            GameForm game = new GameForm(new GameFactory(new RandomAI()), " vs. Easy AI");
            game.MdiParent = this;
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
        }

        private void mediumAIMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildForms();
            GameForm game = new GameForm(new GameFactory(new SmartAI()), " vs. Medium AI");
            game.MdiParent = this;
            game.StartPosition = FormStartPosition.CenterScreen;
            game.Show();
        }
    }
}