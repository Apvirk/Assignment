using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public static class Factory
    {
        // to create random numbers between 0 to 100
        public static int RandomNumber() {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }
       
        // to create punter objects based on name bassed
        public static Punter GetApunter(String name, RadioButton rb, int cash, TextBox label) {
            Punter p=null;

            if (name.ToLower() == "joe") {
                p = new Joe("Joe",rb,cash,label);
            }
            else if (name.ToLower() == "al") {
                 p = new Al("Al", rb, cash, label);
            }else if(name.ToLower() == "bob"){
                p=new Bob("Bob", rb, cash, label);
            }

            return p;

        }



    }
}
