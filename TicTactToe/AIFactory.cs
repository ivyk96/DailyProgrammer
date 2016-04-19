using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTactToe
{
    public class AIFactory
    {
        private Random random = new Random();
        private GameFactory game;

        public AIFactory(GameFactory game)
        {
            this.game = game;       
        }

        public Button Turn(IEnumerable<Button> buttonList)
        {
            // Gets all buttons then choses a button that is not disabled, and returns it.
            List<Button> list = buttonList.ToList();
            list.RemoveAt(0);
            List<Button> tempList = new List<Button>();

            foreach(Button b in list)
            {
                if (b.Enabled == true)
                    tempList.Add(b);
            }

            if (tempList.Count != 0)
                return tempList[random.Next(0, tempList.Count)];
            else
                return null;
        }
    }
}
