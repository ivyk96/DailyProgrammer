using System.Windows.Forms;

namespace TicTactToe
{
    public class GameFactory
    {
        public int Turn = 0;

        public string GetTurn()
        {
            if (Turn == 0)
                return "X";
            else
                return "O";
        }
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