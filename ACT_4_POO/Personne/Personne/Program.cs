using System;

namespace Personne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom;

            double argent;
            
            double donnerArgent;

            string recommencer = "";

            Personne[] personnes = new Personne[2];

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans notre gestionnaire de monnaie !");

                for (int i = 1; i < 3; i++)
                {
                    Console.WriteLine("Personne " + i + ", quel est votre nom?");
                    nom = Console.ReadLine();
                    string argentTemp;
                    Console.WriteLine("Tapez une somme d'argent en euros");
                    do
                    {
                        argentTemp = Console.ReadLine();
                    } while (!double.TryParse(argentTemp, out argent));
                    personnes[i - 1] = new Personne(nom, argent);
                }

                string donnerArgentTemp;
                for (int j = 0; j < personnes.Length; j++)
                {
                    switch (j)
                    {
                        case 0:

                            Console.WriteLine(personnes[j].Name + " combien voulez-vous donner à " + personnes[j + 1].Name);
                            do
                            {
                                donnerArgentTemp = Console.ReadLine();
                            } while (!double.TryParse(donnerArgentTemp, out donnerArgent));

                            if (personnes[j].SiAssezDargent(donnerArgent))
                            {
                                personnes[j].RetirerArgent(donnerArgent);
                                personnes[j + 1].RecevoirArgent(donnerArgent);
                                Console.WriteLine("Ajout effectué!");
                            }
                            else
                            {
                                Console.WriteLine(personnes[j].Name + " vous n'avez pas assez d'Argent pour cette transaction");
                            }

                            break;

                        case 1:
                            Console.WriteLine(personnes[j].Name + " combien voulez-vous donner à " + personnes[j - 1].Name);
                            do
                            {
                                donnerArgentTemp = Console.ReadLine();
                            } while (!double.TryParse(donnerArgentTemp, out donnerArgent));

                            if (personnes[j].SiAssezDargent(donnerArgent))
                            {
                                personnes[j].RetirerArgent(donnerArgent);
                                personnes[j - 1].RecevoirArgent(donnerArgent);
                                Console.WriteLine("Ajout effectué!");
                            }
                            else
                            {
                                Console.WriteLine(personnes[j].Name + " vous n'avez pas assez d'Argent pour cette transaction");
                            }

                            break;
                    }
                    Console.WriteLine(personnes[0].Name + " a " + personnes[0].PorteMonnaie + " Euros dans son porte monnaie");
                    Console.WriteLine(personnes[1].Name + " a " + personnes[1].PorteMonnaie + " Euros dans son porte monnaie");
                }

                Console.WriteLine("Tapez sur espace pour recommencer avec deux autres personnes");
                recommencer = Console.ReadLine();
            } while (recommencer == " ");
            
            Console.ReadLine();
        }
    }
}
