﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Achievement{
        string name;
        bool isUnlocked;
        Image image;
        public string Requirements { get; set; }
        public string Description { get; set; }
        public int secondsRequired { get; set; }
        public difficulty diffRequired { get; set; }
        public Achievement(string name, Image image,int secondsRequired,difficulty diffRequired)
        {
            this.name = name;
            this.image = image;
            this.isUnlocked = false;
            this.secondsRequired = secondsRequired;
            this.diffRequired = diffRequired;
        }
        
        public void Unlock(){this.isUnlocked = true;}
        public bool iSUnlocked() { return isUnlocked; }

        public string getName() { return name; }
        public Image getImage() { return image; }
    }
}
