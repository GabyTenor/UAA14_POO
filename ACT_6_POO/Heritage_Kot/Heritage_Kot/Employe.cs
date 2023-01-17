using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Kot
{
    class Employe : Personne
    {
        private DateTime _dateEmbauche;
        private string _fonction;

        public Employe(DateTime dateEmbauche, string fonction, string nom, string adresse, int codePostal, string localite) : base(nom, adresse, codePostal, localite)
        {
            this._dateEmbauche = dateEmbauche;
            this._fonction = fonction;
        }

        public DateTime DateEmbauche
        {
            get { return _dateEmbauche; }
            set { _dateEmbauche = value; }
        }

        public string Fonction
        {
            get { return _fonction; }
            set { _fonction = value; }
        }


    }
}
