using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TicTactToe
{
    public class RandomAI : AIFactory
    {
        private Random random = new Random();

        public RandomAI()
        {
       
        }

        public Button Turn(IEnumerable<Button> buttonList)
        {
            // AI logic.
            List<Button> list = FilterList(buttonList);

            if (list != null)
                return list[random.Next(0, list.Count)];
            else
                return null;
        }

        private List<Button> FilterList(IEnumerable<Button> buttonList)
        {
            //filters the list and returns a list of all available buttons.
            List<Button> list = buttonList.ToList();
            list.RemoveAt(0);
            list.Reverse();
            List<Button> tempList = new List<Button>();

            foreach(Button b in list)
            {
                if (b.Enabled == true)
                    tempList.Add(b);
            }

            if (tempList.Count != 0)
                return tempList;
            else
                return null;
        }
    }
}
