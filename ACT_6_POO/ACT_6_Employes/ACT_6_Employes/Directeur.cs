using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Employes
{
    class Directeur : Employe
    {
        private int _chiffreDaffaires;
        private int _pourcentage;
        private double _salaire;

        public Directeur(int matricule, string nom, string prenom, DateTime dateDeNaissance, int pourcentage): base(matricule, nom, prenom, dateDeNaissance)
        {
            this._chiffreDaffaires = 50000;
            this._pourcentage = pourcentage;
            this._salaire = CalculSalaire();
        }

        public double CalculSalaire()
        {
            double salaire = 0;

            salaire = _chiffreDaffaires / 100 * _pourcentage;

            return salaire;
        }

        public string CaracteristiquesDirecteur()
        {
            string info = Caracteristiques() + "\nSalaire : " + _salaire;

            return info;
        }
    }
}
