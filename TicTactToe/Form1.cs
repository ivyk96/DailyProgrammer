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
    public partial class Form1 : Form
    {
        private int turn = 0;

        public Form1()
        {
            InitializeComponent();
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
        }
    }
}
