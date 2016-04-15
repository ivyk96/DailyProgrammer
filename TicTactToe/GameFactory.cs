using System.Windows.Forms;

namespace TicTactToe
{
    public class GameFactory
    {
        private int turn = 0;

        public string GetTurn()
        {
            if (turn == 0)
                return "X";
            else
                return "O";
        }

        public string PlayTurn(Button b)
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
            return GetTurn();
        }
    }
}