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

        public int Age()
        {
            int age = (int)this._age;

            return age;
        }
    }
}