﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Animal : ILifeFunctions
    {
        public int hitPoints { get; set; }

        public int Height { get; set; }

        public bool isOrganic { get; set; }

        public string Name { get; set; }

        public virtual void GainSustenance()
        {

        }

        public virtual void Rest()
        {
          
        }

        public void SayName()
        {
            MessageBox.Show("My name is " + Name);
        }

        public virtual void Speak()
        {

        }

        public void Walk()
        {
            MessageBox.Show($"{Name} walks a lonely road... the only one that {Name} has ever known... don't know where it goes... but it's only {Name}, and {Name} walks alone...");
        }
    }
}
