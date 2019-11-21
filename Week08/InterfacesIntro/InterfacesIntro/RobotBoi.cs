using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class RobotBoi : Robot
    {
        bool appearsInFilm { get; set; }

        public RobotBoi(int hitPoints, int height, string Material, string name, bool appearsInFilm)
        {
            this.hitPoints = hitPoints;
            this.Height = height;
            this.Material = Material;
            this.Name = name;
            this.appearsInFilm = appearsInFilm;
        }

    }
}
