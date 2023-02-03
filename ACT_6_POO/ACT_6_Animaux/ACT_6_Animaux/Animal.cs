using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Animaux
{
    class Animal
    {
        protected string _name;
        protected DateTime _bornDate;
        protected int _chip;
        protected int _size;
        protected bool _compAnimal;

        public Animal(string name, DateTime bornDate, int chip, int size, bool compAnimal)
        {
            this._name = name;
            this._bornDate = bornDate;
            this._chip = chip;
            this._size = size;
            this._compAnimal = compAnimal;
        }

        public string Informations()
        {
            string info = _name + "'s size is " + _size + " and was born in " + _bornDate.ToString("MM//dd//yyyy") + ". Its chip number is " + _chip;

            if (_compAnimal)
            {
                info += ". He does competitions";
            }

            return info;
        }
        public string Sleep()
        {
            string isSleeping = _name + " is sleeping";

            return isSleeping;
        }
        public string Eat()
        {
            string isEating = _name + " is eating";

            return isEating;
        }
    }
}
