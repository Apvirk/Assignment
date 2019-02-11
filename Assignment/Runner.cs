using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    // this class represent the car object that race 
    public class Runner
    {
        private string RunnerName;
        private int RacetrackLength;
        private PictureBox MyPictureBox;
        // to set the track length, car name and car image
        public Runner(string RName, int RTLength, PictureBox RPic) {
            this.RunnerName = RName;
            this.RacetrackLength = RTLength;
            this.MyPictureBox = RPic;

           


        }
        // to return the runner name
        public string GetRunnerName() {
            return this.RunnerName;
        }
        // to return the racetrack length
        public int GetRaceTrackLength()
        {
            return this.RacetrackLength;
        }

        // to return the car picture box
        public PictureBox GetMyPictureBox()
        {
            return this.MyPictureBox;
        }

        // to make the car move on the track by a set distance
        public void Move(int distance)
        {
            int x = this.MyPictureBox.Location.X;
            x = x + distance;
            // to remove the car from screen if it reached end of the track
            if (x >= this.GetRaceTrackLength()) {
                this.MyPictureBox.Visible = false;
                return;
            }
            int y= this.MyPictureBox.Location.Y;

            this.MyPictureBox.Location = new Point(x,y );
        }




    }
}
