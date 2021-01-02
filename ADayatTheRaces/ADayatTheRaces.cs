using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayatTheRaces
{
    public partial class Form1 : Form
    {
        enum Guys
        {
            Joe, Bob, Al
        }
        private Guys _selectGuy;

        public Form1()
        {
            InitializeComponent();
        }

        private void RBGuy0_CheckedChanged(object sender, EventArgs e)
        {
            this._selectGuy = Guys.Joe;
            DisplayGuy();
        }

        private void RBGuy1_CheckedChanged(object sender, EventArgs e)
        {
            this._selectGuy = Guys.Bob;
            DisplayGuy();
        }

        private void RBGuy2_CheckedChanged(object sender, EventArgs e)
        {
            this._selectGuy = Guys.Al;
            DisplayGuy();
        }

        private void DisplayGuy()
        {
            BettorLabel.Text = string.Format("{0}", this._selectGuy.ToString());
        }
    }
}
