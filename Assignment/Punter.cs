using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{

    // this class represents the punter that bet on the races
    public abstract class Punter
    {

        protected int Cash;
        protected Bet []MyBet;
        protected int betCount;
        protected TextBox MyLabel;
        protected RadioButton MyRadioButton;
        protected String Name;



        // return all the bets placed by the punter
        public Bet[] GetBets() {
            return MyBet;
        }
        // return the current punter balance
        public int GetCash()
        {
            return Cash;
        }
        // to play the bet for particular race
        public void PlaceBet(Runner r, int amt)
        {
            this.Cash = this.Cash - amt;
            betCount++;
            MyBet[betCount] = new Bet(r, amt);
            Console.WriteLine("Amt: " + MyBet[betCount].Amount +" val passed: " +amt );


        }
        // to enable the radio button if balance cash is greater than zero
        public void EnableRb() {
            //to enable the radio button for placing bets if balance is greater than zero
            if (this.Cash > 0)
            {
                this.MyRadioButton.Enabled = true;
            }
            else {
                this.MyRadioButton.Enabled = false;
            }
        }

        // to return the latested placed bet
        public Bet LatestBet() {
            return MyBet[betCount];
        }
        // to update the textfield display balance
        public void UpdateLabel()
        {
            this.MyLabel.Text = this.Name + " bets $" + this.MyBet[this.betCount].Amount + " on the Car " + this.MyBet[this.betCount].RunnerPlayer.GetRunnerName();
        }

        // to increase punters cash balance as his car has won the race
        public void BetWon()
        {
            int betAmount = this.MyBet[this.betCount].Amount*2;
            //Console.WriteLine("BT: " + betAmount);
            this.Cash = (this.Cash + betAmount);
            //Console.WriteLine("Casg: " + this.Cash);
            this.MyLabel.Text = this.Name + " won and now has $" + this.Cash;

        }
        // to display loss message and also test if punter is busted.
        public void BetLoss()
        {

            // to display busted message if balance is 0
            if (this.Cash <= 0)
            {
                this.MyRadioButton.Enabled = false;
                this.MyLabel.ForeColor = System.Drawing.Color.Red;
                this.MyLabel.Text = "Busted ";
                
            }
            else {
                this.MyLabel.Text = this.Name + " Lost and now has $" + this.Cash;
            }

        }
        // to return punter's name
        public string getName() {
            return this.Name;
        }




    }
}
