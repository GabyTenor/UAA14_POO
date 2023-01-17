using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Kot
{
    class Etudiant : Personne
    {
        private int _annee;
        private string _adKot;

        public Etudiant(int annee, string adKot, string nom, string adresse, int codePostal, string localite) : base(nom, adresse, codePostal, localite)
        {
            this._annee = annee;
            this._adKot = adKot;
        }

        public string FabriqueEtiq()
        {
            string etiquette = "Nom: " + _nom + "\nAdresse de domicile: " +  _localite + ", " + _adresse + "\nCode Postal: " +  _codePostal + "\nAdresse de kot: " + _adKot + "\nCode Postal: 1900" + "\nAnnée d'étude: " + _annee;

            return etiquette;
        }

        public int Annee
        {
            get { return _annee; }
            set { _annee = value; }
        }

        public string adKot
        {
            get { return _adKot; }
            set { _adKot = value; }
        }

    }
}
