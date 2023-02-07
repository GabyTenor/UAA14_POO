using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Employes
{
    class Ouvrier : Employe
    {
        private DateTime _entree;
        private int _salaire;

        public Ouvrier(int matricule, string nom, string prenom, DateTime dateDeNaissance, DateTime entree) : base(matricule, nom, prenom, dateDeNaissance)
        {
            this._entree = entree;
            this._salaire = CalculeSalaire(); 
        }

        public int CalculeSalaire()
        {
            int salaire = 2500;

            DateTime today = new DateTime();
            today = DateTime.Now;

            TimeSpan tempsEmploye = today - _entree;

            int tempsTravail = (int)(tempsEmploye.TotalDays / 365);

            if(salaire !> 5000)
            {
                salaire += 100 * tempsTravail;
            }

            return salaire;
        }

        public string Caracteristiques()
        {
            string info = Caracteristiques() + "\nSalaire : " + _salaire;

            return info;
        }
    }
}
