using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Animaux
{
    class Chien : Animal
    {
        public Chien(string name, DateTime bornDate, int chip, int size, bool compAnimal) : base(name, bornDate, chip, size, compAnimal)
        {

        }

        public string Bark()
        {
            string info = _name + " is barking at you!";

            return info;
        }
    }
}
