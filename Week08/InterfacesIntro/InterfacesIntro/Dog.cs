﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Dog : Animal
    {
        public string Breed;

        public override void Speak()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name, int hitPoints)
        {
            this.Breed = breed;
            this.Height = height;
            this.Name = name;
            this.hitPoints = hitPoints;
        }
    }
}