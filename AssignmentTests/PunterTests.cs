using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass()]
    public class PunterTests
    {
        [TestMethod()]
        public void BetWonTest()
        {
            Runner r1 = new Runner("1", 1000, new System.Windows.Forms.PictureBox());

            Punter p = Factory.GetApunter("Joe", new System.Windows.Forms.RadioButton(), 50, new System.Windows.Forms.TextBox());
            p.PlaceBet(r1, 10);
            p.BetWon();
            Assert.AreEqual(60, p.GetCash(), 0, "Validate failed expected return value 60 got " + p.GetCash());
        }
    }
}