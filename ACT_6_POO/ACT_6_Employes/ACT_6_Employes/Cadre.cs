using System;
using System.Collections.Generic;
using System.Text;

namespace ACT_6_Employes
{
    class Cadre : Employe
    {
        private int _indice;
        private int _salaire;

        public Cadre(int matricule, string nom, string prenom, DateTime dateDeNaissance, int indice) : base(matricule, nom, prenom, dateDeNaissance)
        {
            this._indice = indice;
            this._salaire = CalculSalaire();
        }

        public int CalculSalaire()
        {
            int salaire = 0;

            switch (_indice)
            {
                case 1:
                    salaire = 13000;
                    break;

                case 2:
                    salaire = 15000;
                    break;

                case 3:
                    salaire = 17000;
                    break;

                case 4:
                    salaire = 20000;
                    break;
            }

            return salaire;
        }

        public string CaracteristiquesCadre()
        {
            string info = Caracteristiques() + "\nSalaire : " + _salaire;

            return info;
        }
    }
}
