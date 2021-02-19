using System;
using System.Collections.Generic;
using System.Text;

namespace Csharquarium.models
{
    abstract class Herbivores : Poisson //alt enter genère le constructeur
    {
        public Herbivores(string nom, Genre sexe) : base(nom, sexe)
        {

        }

        public virtual void Manger(Algue a)
        {
            a.PV -= 2;
            this.PV += 3;
        }
    }
}
