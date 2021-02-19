using Csharquarium.models;
using System;

namespace Csharquarium
{
    class Program
    {
        static Aquarium aqua = new Aquarium();
        static void Main(string[] args)
        {

            //Le nombre d’algues présentes
            //La liste des poissons avec leur nom et leur sexe.

         



            
            

            while (true)
            {
                Console.Clear();
                aqua.Afficher(); //ecriture de nos poissons et nb d'algues
                Console.WriteLine("Que voulez vous faire? ");
                Console.WriteLine("1 Ajouter une poisson");
                Console.WriteLine("2 Ajouter une algue");
                Console.WriteLine("3 Passer au jour suivant");
                Console.WriteLine("4 Sauvegarder");
                Console.WriteLine("5 Quitter");

                string choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Choix1();
                        break;
                    case "2":
                        Choix2();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }

            }

        }

        private static void Choix1()
        {

            string type = Question("Veuillez entrer le type de votre poisson");
            string nom = Question("Entrez le nom de votre poisson: ");
            string s = Question("Entrez le sexe de votre poisson");
            string age = Question("Veuillez rentrer un age");

            Genre genre; //definir la variable  du Genre
            while (!Enum.TryParse(s, out genre)) //transformation en chaine de caractère car c'est un type enum, si je n'y arrive pas je repose la question
            {
                s = Question("Entrez le sexe de votre poisson");
            }
            //definir la variable  du Genre
            int AgeP;
            while (!int.TryParse(s, out AgeP)) //transformation en chaine de caractère car c'est un type enum, si je n'y arrive pas je repose la question
            {
                age = Question("Veuillez rentrer un age");
            }

            aqua.AjouterPoisson(nom, genre, type, AgeP);



        }

        private static void Choix2()
        {
            
                Algue a = new Algue();
                aqua.Ajouter(a);
            
           
        }

        private static string Question(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }



    }
}