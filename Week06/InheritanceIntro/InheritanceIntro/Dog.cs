using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Dog : Animal
    {
        public string breed;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public Dog() { }

        public Dog(string breed, int height, string name)
        {
            this.breed = breed;
            this.height = height;
            this.name = name;
        }
    }
}