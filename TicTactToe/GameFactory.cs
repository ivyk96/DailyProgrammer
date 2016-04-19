using System.Collections.Generic;
using System.Linq;
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

        public string CheckWinner(IEnumerable<Button> buttonList)
        {
            List<Button> list = buttonList.ToList();
            string winner = "";

            //Horizontal checks
            // X
            if (list[8].Text == "X" && list[7].Text == "X" && list[6].Text == "X")
            {
                winner = "X wins!";
            }
            else if (list[5].Text == "X" && list[4].Text == "X" && list[3].Text == "X")
            {
                winner = "X wins!";
            }
            else if (list[2].Text == "X" && list[1].Text == "X" && list[0].Text == "X")
            {
                winner = "X wins!";
            }
            // O
            else if (list[8].Text == "O" && list[7].Text == "O" && list[6].Text == "O")
            {
                winner = "O wins!";
            }
            else if (list[5].Text == "O" && list[4].Text == "O" && list[3].Text == "O")
            {
                winner = "O wins!";
            }
            else if (list[2].Text == "O" && list[1].Text == "O" && list[0].Text == "O")
            {
                winner = "O wins!";
            }

            //Vertical checks
            // X
            if (list[8].Text == "X" && list[5].Text == "X" && list[2].Text == "X")
            {
                winner = "X wins!";
            }
            else if (list[7].Text == "X" && list[4].Text == "X" && list[1].Text == "X")
            {
                winner = "X wins!";
            }
            else if (list[6].Text == "X" && list[3].Text == "X" && list[0].Text == "X")
            {
                winner = "X wins!";
            }
            // O
            else if (list[8].Text == "O" && list[5].Text == "O" && list[2].Text == "O")
            {
                winner = "O wins!";
            }
            else if (list[7].Text == "O" && list[4].Text == "O" && list[1].Text == "O")
            {
                winner = "O wins!";
            }
            else if (list[6].Text == "O" && list[3].Text == "O" && list[0].Text == "O")
            {
                winner = "O wins!";
            }

            //Diagonal checks
            // X
            if (list[8].Text == "X" && list[4].Text == "X" && list[0].Text == "X")
            {
                winner = "X wins!";
            }
            else if (list[6].Text == "X" && list[4].Text == "X" && list[2].Text == "X")
            {
                winner = "X wins!";
            }
            // O
            else if (list[8].Text == "O" && list[4].Text == "O" && list[0].Text == "O")
            {
                winner = "O wins!";
            }
            else if (list[6].Text == "O" && list[4].Text == "O" && list[2].Text == "O")
            {
                winner = "O wins!";
            }

            return winner;
        }
    }
}