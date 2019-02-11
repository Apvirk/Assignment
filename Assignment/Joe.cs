using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    // Sub class of punter
    public class Joe: Punter
    {
        //constructor to set initial values

        public Joe(String name, RadioButton rb, int cash, TextBox label)
        {

            this.Cash = cash;
            this.Name = name;
            this.MyRadioButton = rb;
            this.MyLabel = label;
            this.betCount = -1;
            this.MyBet = new Bet[20];

        }
    }
}
