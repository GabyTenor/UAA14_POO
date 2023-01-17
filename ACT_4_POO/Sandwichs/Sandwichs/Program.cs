using System;

namespace Sandwichs
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMaker distributeur = new SandwichMaker();
            string utiliser;

            Console.WriteLine("Bienvenue dans notre concepteur de sandwich!");

            do
            {             
                Console.WriteLine("Tapez sur espace pour générer un sandwich, n'importe quelle touche pour quitter!");

                string sandwich = distributeur.ComposeSandwich();
                Console.WriteLine(sandwich);

                utiliser = Console.ReadLine();
            } while (utiliser == " ");
            
        }
    }
}
