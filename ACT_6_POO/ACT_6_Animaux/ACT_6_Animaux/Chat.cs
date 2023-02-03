using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Animaux
{
    class Chat : Animal
    {
        public Chat(string name, DateTime bornDate, int chip, int size, bool compAnimal) : base(name, bornDate, chip, size, compAnimal)
        {

        }

        public string Purr()
        {
            string info = _name + " started to purr when he saw you";

            return info;
        }
    }
}
