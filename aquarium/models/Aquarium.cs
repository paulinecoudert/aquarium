using System;
using System.Collections.Generic;
using System.Text;

namespace Csharquarium.models
{
    class Aquarium
    {
        private Random r = new Random();


        private List<Poisson> _ListPoissons = new List<Poisson>();
        private List<Algue> _ListAlgues = new List<Algue>();


        public void AjouterPoisson(string nom, Genre sexe, string type, int AgeP)
        {

            /* Créer instance de l'objet sur base du nom et type de l'objet à la place de faire le switch
           * 
           * type t = Assembly.GetExecutiveAssembly().GetType(type);
           * ConstructorInfo ctor = t.GetConstructor(new [] {typeof(string), typeof(Genre) });
           * Poisson nouveau = (Poisson)ctor.Invoke(new object[] {nom, sexe});
           
           */


            Poisson nouveau = null; //declaration du poisson

            nouveau.Age = AgeP;

            switch (type)
            {
                case "Carpe":
                    nouveau = new Carpe(nom, sexe);
                    break;
                case "Sole":
                    nouveau = new Sole(nom, sexe);
                    break;
                case "Bar":
                    nouveau = new Bar(nom, sexe);
                    break;
                case "Merou":
                    nouveau = new Merou(nom, sexe);
                    break;
                case "Thon":
                    nouveau = new Thon(nom, sexe);
                    break;
                case "PoissonClown":
                    nouveau = new PoissonClown(nom, sexe);
                    break;
            }

          



            _ListPoissons.Add(nouveau); //j'ajoute mon poisson à la fin

            //crer une instance de poisson
            //ajouter l'instance que part

        }


        public void Ajouter(Algue a)
        {
            _ListAlgues.Add(a);

        }

        public void JourDePLus()
        {


            List<EtreVivants> ASupprimer = new List<EtreVivants>(); //doit creer une liste vide pour mettre les elements que je vais supprimer


            foreach (var p in _ListPoissons)
            {
                p.PV--;
                p.Age++;
                //EtreVivants victim = null ;
                if (p.Age >=20 || p.PV <= 0)
                {
                    ASupprimer.Add(p);
                }


                if (p.PV <= 5)
                {
                    if (p is Carnivores)
                    {
                        int alea = r.Next(0, _ListPoissons.Count);
                        Poisson victime = _ListPoissons[alea];
                        if (victime != p && victime.GetType() != p.GetType())
                        {
                            ((Carnivores)p).Manger(victime); //caster le poisson en carnivore ((Carnivores)p)
                            if (victime.PV <= 0 || victime.Age >=20)
                            {
                                ASupprimer.Add(victime);
                             
                            }

                            
                        }

                    }
                    if (p is Herbivores)
                    {
                        
                        int alea = r.Next(0, _ListAlgues.Count);
                        Algue victime = _ListAlgues[alea];
                        ((Herbivores)p).Manger(victime); //caster le poisson en Herbivore ((Herbivore)p
                        if (victime.PV <= 0 && victime.Age >= 20)
                        {
                            ASupprimer.Add(victime);
                        }
                    }
                }

                

            }

            foreach (var a in _ListAlgues)
            {
                a.PV++;
                a.Age++;

                if (a.Age >= 20 || a.PV <= 0)
                {
                    ASupprimer.Add(a);
                }

            }
            foreach (EtreVivants victim in ASupprimer)
            {
                _ListPoissons.Remove((Poisson)victim);
                _ListAlgues.Remove((Algue)victim);
               
            }


        }



        public void Afficher()
        {



            Console.WriteLine($"Nombre d'algues: {_ListAlgues.Count}");

            foreach (var p in _ListPoissons)
            {
                Console.WriteLine($"Type: {p.GetType().Name} - Nom: {p.Nom} - sexe: {p.Sexe}");
            }

        }







    }
}
