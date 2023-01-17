using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwichs
{
    class SandwichMaker
    {
        private string[] _proteine = new string[4] { "Jambon", "Steak", "Fricadelle", "Oeuf"};
        private string[] _sauces = new string[5] { "Ketchup", "Mayonnaise", "Andalouse", "Moutarde", "Samouraï" };
        private string[] _pain = new string[3] { "Pain sésame", "Pain blanc", "Pain blanc" };
        private string[] _crudites = new string[5] { "Salade", "Tomtates", "Ognions", "Cornichons", "Concombre" };

        public string ComposeSandwich()
        {
            Random rnd = new Random();

            string sandwich = "Voici votre sandwich" + _pain[rnd.Next(0, _pain.Length - 1)] + ", " + _proteine[rnd.Next(0, _proteine.Length - 1)] + ", " + _sauces[rnd.Next(0, _sauces.Length - 1)] + ", " + _crudites[rnd.Next(0, _crudites.Length - 1)];

            return sandwich;
        }
    }
}
