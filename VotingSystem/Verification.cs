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
    public partial class VotingSystem : Form
    {
        public VotingSystem()
        {
            InitializeComponent();
        }

        private void verificationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PartySelector PartyForm = new PartySelector();
            PartyForm.ShowDialog();
        }
    }
}
