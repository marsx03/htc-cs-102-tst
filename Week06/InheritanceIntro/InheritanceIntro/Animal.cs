using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Animal
    {
        public string name;
        public int height;
        public int vibes;

        public void SayName()
        {
            MessageBox.Show($"My name is {name}";
        }

        public void VibeCheck()
        {
            MessageBox.Show("VIBE CHECK IN PROGRESS.............");
        
            Random gen = new Random();
            vibes = gen.Next(100);

            string result = "";

            if (this.vibes >= 69)
            {
                result = "Vibe Check Passed :) Gucci Gang \n \n \n Until next time......";
            }

            else
            {
                result = "Vibe Check Failed >:( Big Poopy On U";
            }

            MessageBox.Show($"{name}'s Result: {result}");
        }


    }
}
