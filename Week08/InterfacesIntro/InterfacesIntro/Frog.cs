﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Frog : Animal
    {
        public bool IsPoisonous;

        public override void Speak()
        {
            MessageBox.Show("Ribbit");
        }

        public Frog() { }

        public Frog(int height, string name, bool isPoisonous, int hitPoints)
        {
            this.IsPoisonous = isPoisonous;
            this.Height = height;
            this.Name = name;
            this.hitPoints = hitPoints;
        }
    }
}