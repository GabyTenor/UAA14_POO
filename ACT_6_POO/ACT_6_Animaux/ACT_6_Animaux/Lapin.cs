using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Animaux
{
    class Lapin : Animal
    {
        public Lapin(string name, DateTime bornDate, int chip, int size, bool compAnimal) : base(name, bornDate, chip, size, compAnimal)
        {

        }

        public string Jump()
        {
            Random rnd = new Random();
            double jumpHeight = rnd.Next(1, 2);

            string info = _name + "happyly jumped " + jumpHeight + " meter height when he saw you!!";

            return info;
        }

    }
}
