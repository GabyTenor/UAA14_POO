using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_1_POO
{
    class chien
    {

        private string _nom;
        private uint _age;
        private string _race;

        public chien(string nom, uint age, string race)
        {
                this._nom = nom;
                this._age = age;
                this._race = race;
        }

        public void AfficheCaracteristiques()
        {
                Console.WriteLine("Nom : " + this._nom + " - Age : " + this._age + " - Race : " + this._race);         
        }

        static void Moyenne(out int average, chien[] Hund)
        {
            average = 0;
            int somTotale;

            for (int i = 0; i < Hund.Length; i++)
            {
                somTotale = somTotale + Hund[i]._age;
            }
        }
    }
}
