using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Kot
{
    class Personne
    {
        protected string _nom;
        protected string _adresse;
        protected int _codePostal;
        protected string _localite;

        public Personne(string nom, string adresse, int codePostal, string localite)
        {
            this._nom = nom;
            this._adresse = adresse;
            this._codePostal = codePostal;
            this._localite = localite;
        }

        public string FabriqueEtiq()
        {
            string etiquette = "Nom: " +_nom + "\nAdresse: " + _localite + ", " + _adresse + "\nCode Postal: " + _codePostal;
             
            return etiquette;
        }

        public string EstVoisin(Etudiant etud)
        {
            string voisin = "";

            if(_codePostal == etud._codePostal)
            {
                voisin = _nom + " vit au même endroit que " + etud._nom;
            }

            return voisin;
        }

        public string Nom
        { 
            get { return _nom; }
            set { _nom = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public int codePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }

        public string Localite
        {
            get { return _localite; }
            set { _localite = value; }
        }



    }
}
