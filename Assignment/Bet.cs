using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    // THis class represent the bets placed by the punters
    public class Bet
    {

        // to store the car on whom the bet is placed
        public Runner RunnerPlayer { get; set; }
        //to store the bet amount
        public int Amount { get; set; }
        // to create bet object with runner and bet amount
        public Bet(Runner runner,int amt) {
            this.RunnerPlayer = runner;
            this.Amount = amt;
        }

        
    }
}
