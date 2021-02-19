using System;
using System.Collections.Generic;
using System.Text;

namespace Csharquarium.models
{
    abstract class Carnivores : Poisson //faire alt enter et ça génère
    {
        public Carnivores(string nom, Genre sexe) : base(nom, sexe) 
        {

        }

        public void Manger(Poisson victime)
        {
            victime.PV -= 4;
            this.PV += 5;
        }

    }
}
 