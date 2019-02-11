using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        // to create four racing cars
        Runner r1, r2, r3, r4;
        // to create the betting punters
        Punter  joe, al, bob;
        Boolean tocheck;
        // array to store bets data
        Bet []currentBets;
        public Form1()
        {
            InitializeComponent();
            // creating punter object using factory class
            joe = Factory.GetApunter("Joe", this.rbJoe, 50,this.tbJoe);
            al = Factory.GetApunter("Al", this.rbAl, 50,this.tbAl);
            bob = Factory.GetApunter("Bob", this.rbBob, 50,this.tbBob);
            currentBets = new Bet[3];

        }

        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            // to place better
            Bet bet=null;
            
            Runner car=null;
            // setting the car based on number selection
            if (numRacer.Value == 1) {
                car = r1;
            } else if ((int)numRacer.Value ==2) {
                car = r2;
            } else if ((int)numRacer.Value == 3)
            {
                car = r3;
            } else if ((int)numRacer.Value == 4)
            {
                car = r4;
            }

            // to place the bet for particular player based on selection using radio button for the player
            if (rbJoe.Checked == true) {
                rbJoe.Enabled = false;
                rbJoe.Checked = false;
                joe.PlaceBet(car, (int)numAmt.Value);
                currentBets[0] = joe.LatestBet();
                joe.UpdateLabel();
            }else if (rbBob.Checked == true)
            {
                rbBob.Enabled = false;
                rbBob.Checked = false;
                bob.PlaceBet(car, (int)numAmt.Value);
                currentBets[1] = bob.LatestBet();
                bob.UpdateLabel();
            }
            else if (rbAl.Checked == true)
            {
                rbAl.Enabled = false;
                rbAl.Checked = false;
                al.PlaceBet(car, (int)numAmt.Value);
                currentBets[2] = al.LatestBet();
                al.UpdateLabel();
            }

        }

        private void rbBob_CheckedChanged(object sender, EventArgs e)
        {
            // to allow max 45 or maximum amount of punter's balance for betting for bob
            if (this.rbBob.Checked == true)
            {
                
                if (bob.GetCash() >= 45)
                {
                    numAmt.Maximum = 45;

                }
                else
                {
                    numAmt.Maximum = bob.GetCash();
                }

            }
        }
            
        private void rbAl_CheckedChanged(object sender, EventArgs e)
        {
            // to allow max 45 or maximum amount of punter's balance for betting for Al
            if (this.rbAl.Checked == true)
            {
               
             
                if (al.GetCash() >= 45)
                {
                    numAmt.Maximum = 45;

                }
                else
                {
                    numAmt.Maximum = al.GetCash();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // to allow max 45 or maximum amount of punter's balance for betting for Joe
            if (this.rbJoe.Checked == true) {
             
                if (joe.GetCash() >= 45)
                {
                    numAmt.Maximum = 45;

                }
                else {
                    numAmt.Maximum = joe.GetCash();
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset() {
            //to reset all the controls
            r1.GetMyPictureBox().Location = new Point(12, r1.GetMyPictureBox().Location.Y);
            r2.GetMyPictureBox().Location = new Point(12, r2.GetMyPictureBox().Location.Y);
            r3.GetMyPictureBox().Location = new Point(12, r3.GetMyPictureBox().Location.Y);
            r4.GetMyPictureBox().Location = new Point(12, r4.GetMyPictureBox().Location.Y);
            r4.GetMyPictureBox().Visible = true;
            r3.GetMyPictureBox().Visible = true;
            r2.GetMyPictureBox().Visible = true;
            r1.GetMyPictureBox().Visible = true;

            joe.EnableRb();
            bob.EnableRb();
            al.EnableRb();

            numAmt.Value = 1;
            numRacer.Value = 1;


            timer1.Enabled = false;
            btnPlaceBet.Enabled = true;
            currentBets = new Bet[3];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnPlaceBet.Enabled = false;
            btnReset.Enabled = false;
            tocheck = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // creating four cars for racing
             r1 = new Runner("1", 1000, this.pictureBox2);
             r2 = new Runner("2", 1000, this.pictureBox3);
             r3 = new Runner("3", 1000, this.pictureBox4);
             r4 = new Runner("4", 1000, this.pictureBox5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // for car movement and checking win condition

            // getting randnumber from the Factory class
            // moving the player based on the random number generator
            int random=Factory.RandomNumber();
            if (random > 15 && random <= 30)
            {
                r1.Move(7);
            }
            if (random > 30 && random <= 45)
            {
                r2.Move(7);
            }
            if (random > 45 && random <= 60)
            {
                r3.Move(7);
            }
            if (random > 60 && random <= 75)
            {
                r4.Move(7);
            }
            // to keep the cars moving
            r1.Move(1);
            r2.Move(1);
            r3.Move(1);
            r4.Move(1);
            if (tocheck)
            {
                // to stop when any of the car reaches the win line of track

                if (r1.GetMyPictureBox().Location.X >= 1000 - 100)
                {
                    btnReset.Enabled = true;

                    tocheck = false;
                    // to display win message
                    MessageBox.Show("Car 1 won");
                    //to check if joe has placed a bet
                    if (currentBets[0] != null)
                    {
                        // to check if joe bet on the first car 
                        if (currentBets[0].RunnerPlayer.GetRunnerName() == r1.GetRunnerName())
                        {
                            // to increase cash amount as the bettor car won
                            joe.BetWon();
                        }
                        else
                        {
                            // to display the loss as bettor's car didn't won
                            joe.BetLoss();
                        }
                    }
                    //to check if bob has placed a bet
                    if (currentBets[1] != null) { 
                        if (currentBets[1].RunnerPlayer.GetRunnerName() == r1.GetRunnerName())
                        {
                            bob.BetWon();
                        }
                        else
                        {
                            bob.BetLoss();
                        }
                    }
                    //to check if al has placed a bet
                    if (currentBets[2] != null)
                    {
                        if (currentBets[2].RunnerPlayer.GetRunnerName() == r1.GetRunnerName())
                        {
                            al.BetWon();
                        }
                        else {
                            al.BetLoss();
                        }

                    }

                    
                }
                // similary way like car 1 check if other cars have won and increase the punter's balance
                // if their select car has won
                else if (r2.GetMyPictureBox().Location.X >= 1000 - 100)
                {
                    btnReset.Enabled = true;
                    tocheck = false;
                    MessageBox.Show("Car 2 won");
                    if (currentBets[0] != null)
                    {
                        if (currentBets[0].RunnerPlayer.GetRunnerName() == r2.GetRunnerName())
                        {
                            joe.BetWon();
                        }
                        else
                        {
                            joe.BetLoss();
                        }
                    }
                    if (currentBets[1] != null)
                    {
                        if (currentBets[1].RunnerPlayer.GetRunnerName() == r2.GetRunnerName())
                        {
                            bob.BetWon();
                        }
                        else
                        {
                            bob.BetLoss();
                        }
                    }
                    if (currentBets[2] != null)
                    {
                        if (currentBets[2].RunnerPlayer.GetRunnerName() == r2.GetRunnerName())
                        {
                            al.BetWon();
                        }
                        else
                        {
                            al.BetLoss();
                        }

                    }

                }
                else if (r3.GetMyPictureBox().Location.X >= 1000 - 100)
                {
                    btnReset.Enabled = true;
                    tocheck = false;
                    MessageBox.Show("Car 3 won");
                    if (currentBets[0] != null)
                    {
                        if (currentBets[0].RunnerPlayer.GetRunnerName() == r3.GetRunnerName())
                        {
                            joe.BetWon();
                        }
                        else
                        {
                            joe.BetLoss();
                        }
                    }
                    if (currentBets[1] != null)
                    {
                        if (currentBets[1].RunnerPlayer.GetRunnerName() == r3.GetRunnerName())
                        {
                            bob.BetWon();
                        }
                        else
                        {
                            bob.BetLoss();
                        }
                    }
                    if (currentBets[2] != null)
                    {
                        if (currentBets[2].RunnerPlayer.GetRunnerName() == r3.GetRunnerName())
                        {
                            al.BetWon();
                        }
                        else
                        {
                            al.BetLoss();
                        }

                    }

                }
                else if (r4.GetMyPictureBox().Location.X >= 1000 - 100)
                {
                    btnReset.Enabled = true;
                    tocheck = false;
                    MessageBox.Show("Car 4 won");
                    if (currentBets[0] != null)
                    {
                        if (currentBets[0].RunnerPlayer.GetRunnerName() == r4.GetRunnerName())
                        {
                            joe.BetWon();
                        }
                        else
                        {
                            joe.BetLoss();
                        }
                    }
                    if (currentBets[1] != null)
                    {
                        if (currentBets[1].RunnerPlayer.GetRunnerName() == r4.GetRunnerName())
                        {
                            bob.BetWon();
                        }
                        else
                        {
                            bob.BetLoss();
                        }
                    }
                    if (currentBets[2] != null)
                    {
                        if (currentBets[2].RunnerPlayer.GetRunnerName() == r4.GetRunnerName())
                        {
                            al.BetWon();
                        }
                        else
                        {
                            al.BetLoss();
                        }

                    }

                }
            }

            if (r1.GetMyPictureBox().Location.X > 1000 &&

                r2.GetMyPictureBox().Location.X > 1000 &&
                r3.GetMyPictureBox().Location.X > 1000 &&
                r4.GetMyPictureBox().Location.X > 1000

                )
            {
                // to enable reset button  when all the care read end line
                btnReset.Enabled = true;
                // to stop the timer as race is over
                timer1.Enabled = false;
               
            }



        }
    }
}
