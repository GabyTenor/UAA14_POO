using System;
using System.Collections.Generic;
using System.Text;

namespace Cercles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cercle> cercles = new List<Cercle>();
            
            string entree;
            double rayon;

            string utiliser = " ";

            int numeroCercle = -1;

            Console.WriteLine("Bienvenue dans ce programme sur le cercle !");

            do
            {
                numeroCercle++;
                Console.WriteLine("Tapez un rayon pour votre cercle.");
                do
                {
                    entree = Console.ReadLine();
                } while (!double.TryParse(entree, out rayon));

                cercles.Add(new Cercle(rayon));

                double aire = cercles[numeroCercle].CalculeAire();
                double perimetre = cercles[numeroCercle].CalculePerimetre();

                cercles[numeroCercle].Caracteristiques(perimetre, aire);

                /*Console.WriteLine("Voulez-vous voir tous vos cercles?");
                string voirTout = Console.ReadLine();
                if(voirTout == "oui")
                {
                    foreach(Cercle i in cercles)
                    {
                        cercles[i].Caracteristiques(perimetre, aire);
                    }
                }*/

                Console.WriteLine("Un autre cercle? (Tapez sur espace)");
                utiliser = Console.ReadLine();

            } while (utiliser == " ");
        }
    }
}
