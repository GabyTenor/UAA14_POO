using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personne
{
    internal class Personne
    {
        private string _name;
        private double _porteMonnaie;

        public Personne(string name, double porteMonnaie)
        {
            this._name = name;
            this._porteMonnaie = porteMonnaie;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double PorteMonnaie
        {
            get { return _porteMonnaie; }
            set { _porteMonnaie = value; }
        }

        public bool SiAssezDargent(double donnerArgent)
        {
            bool assezDargent;
            
            if(donnerArgent <= _porteMonnaie)
            {
                assezDargent = true;
            }
            else
            {
                assezDargent = false;
            }

            return assezDargent;
        }

        public void RetirerArgent(double donnerArgent)
        {
            _porteMonnaie = _porteMonnaie - donnerArgent;
        }

        public void RecevoirArgent(double donnerArgent)
        {
            _porteMonnaie = _porteMonnaie + donnerArgent;
        }

    }
}
