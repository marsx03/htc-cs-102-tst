using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    interface ILifeFunctions
    {
        int hitPoints { get; set; }
        bool isOrganic { get; set; }

        void GainSustenance();
        void Walk();
        void Rest();


    }
}
