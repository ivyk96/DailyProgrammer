using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class PartySelector : Form
    {
        public PartySelector()
        {
            InitializeComponent();
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            voteBox.Items.Clear();

            switch (voteBox.SelectedIndex)
            {
                case 0: foreach (var s in p)
            }
        }
    }
}
