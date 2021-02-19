using System;
using System.Collections.Generic;
using System.Text;

namespace Csharquarium.models
{
   public abstract class Poisson : EtreVivants
    {
        public string Nom { get; set; }
        public Genre Sexe { get; set; }

       


        public Poisson(string nom, Genre sexe)
        {
            Nom = nom;
            Sexe = sexe;
           
        }

        

        

        


      

        //internal abstract void Manger(Poisson poisson);
    }
}
