using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayatTheRaces
{
    public class Guy
    {
        public string name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {

        }
        public void ClearBet()
        {

        }
        public bool PlaceBet(int Amount, int Dog)
        {
            return true;
        }
        public void Collect(int Winner)
        {

        }
    }
}