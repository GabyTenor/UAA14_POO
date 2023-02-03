using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Employes
{
    class Employe
    {
        protected int _matricule;
        protected string _nom;
        protected string _prenom;
        protected DateTime _dateDeNaissance;

        public Employe(int matricule, string nom, string prenom, DateTime dateDeNaissance)
        {
            this._matricule = matricule;
            this._nom = nom;
            this._prenom = prenom;
            this._dateDeNaissance = dateDeNaissance;
        }

        public string Caracteristiques()
        {
            string info = "Nom : " + _nom + "\nPrénom : " + _prenom + "\nMatricule : " + _matricule + "\nDate de naissance : " + _dateDeNaissance.ToString("MM//dd//yyyy");

            return info;
        }
    }
}
