using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class GameForm : Form
    {
        Random dice = new Random();
        int secondsplayed;
        int minutesplayed;
        public GameForm()
        {
            InitializeComponent();
        }
        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GameStarted = false)
            MessageBox.Show("No game started yet");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roll_Click(object sender, EventArgs e)
        {
            diceOutcomeLabel1.Text = dice.Next(1, 7).ToString();
            diceOutcomeLabel2.Text = dice.Next(1, 7).ToString();

            totalStepsLabel.Text = (int.Parse(diceOutcomeLabel1.Text) + int.Parse(diceOutcomeLabel2.Text)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsplayed++;          
            if (secondsplayed % 60 == 0)
            {
                minutesplayed++;
                secondsplayed = 0;
            }
            if (secondsplayed < 10)
                playtimeLabel.Text = minutesplayed.ToString() + ":0" +  secondsplayed.ToString();

            if (secondsplayed > 10)
                playtimeLabel.Text = minutesplayed.ToString() + ":" + secondsplayed.ToString();
        }
    }
}
