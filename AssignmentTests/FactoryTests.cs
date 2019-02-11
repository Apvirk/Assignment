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
    public class FactoryTests
    {
        [TestMethod()]
        public void GetApunterTest()
        {
            //to check if correct punter object is returned
            Punter p = Factory.GetApunter("Joe", new System.Windows.Forms.RadioButton(), 50, new System.Windows.Forms.TextBox());

            Assert.AreEqual("Joe", p.getName(), "Validate failed expected return value 'Joe' got '" + p.getName() + "'");
            p = Factory.GetApunter("al", new System.Windows.Forms.RadioButton(), 50, new System.Windows.Forms.TextBox());
            Assert.AreEqual("Al", p.getName(), "Validate failed expected return value 'Al' got '" + p.getName() + "'");

            p = Factory.GetApunter("bob", new System.Windows.Forms.RadioButton(), 50, new System.Windows.Forms.TextBox());
            Assert.AreEqual("Bob", p.getName(), "Validate failed expected return value 'Bob' got '" + p.getName() + "'");
        }
    }
}