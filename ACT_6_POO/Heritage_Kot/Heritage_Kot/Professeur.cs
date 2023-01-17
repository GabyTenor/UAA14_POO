using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Kot
{
    class Professeur : Personne
    {
        private string _specialisation;

        public Professeur(string specialisation, string nom, string adresse, int codePostal, string localite) : base(nom, adresse, codePostal, localite)
        {
            this._specialisation = specialisation;
        }

        public string Specialisation
        {
            get { return _specialisation; }
            set { _specialisation = value; }
        }

    }
}
