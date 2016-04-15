using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTactToe
{
    public class GameFactory
    {
        private int turn = 0;

        public Button Turn(Button b)
        {
            if(turn == 0)
            {
                b.Text = "X";
                turn++;
            }
            else
            {
                b.Text = "O";
                turn--;
            }

            b.Enabled = false;
            return b;
        }
    }
}
