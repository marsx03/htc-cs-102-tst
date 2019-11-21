using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    class Robot : ILifeFunctions
    {
        //interface def: a template for a class that sets the guidelines for what a child class MUST have

        public int hitPoints { get; set; }

        public int Height { get; set; }

        public bool isOrganic { get; set; }

        public string Material { get; set; }

        public string Name { get; set; }

        public virtual void GainSustenance()
        {
          
        }

        public virtual void Rest()
        {

        }

        public void Walk()
        {
            MessageBox.Show($"Beep Beep Boop Bop 11010101110101 ... {Name} moved forward....")
        }
    }
}
