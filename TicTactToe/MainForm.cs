using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTactToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void singleplayerButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form gameForm = new GameForm(false);
            gameForm.ShowDialog();
        }

        private void multiplayerButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form gameForm = new GameForm(true);
            gameForm.ShowDialog();
        }
    }
}
