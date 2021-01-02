﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADayatTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;
        
        public bool Run()
        {
            Randomizer = new Random();
            int distance = Randomizer.Next(1, 4);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            return true;
        }
        public void TakeStartingPosition()
        {
            this.Location = StartingPosition;
        }
    }
}