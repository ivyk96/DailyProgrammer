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
        public int Turn = 0;

        public Button PlayTurn(Button b)
        {
            if(Turn == 0)
            {
                b.Text = "X";
                Turn++;
            }
            else
            {
                b.Text = "O";
                Turn--;
            }

            b.Enabled = false;
            return b;
        }
    }
}
