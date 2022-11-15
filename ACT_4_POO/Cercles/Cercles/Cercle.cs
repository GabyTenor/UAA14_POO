using System;
using System.Collections.Generic;
using System.Text;

namespace Cercles
{
    public class Cercle
    {
        private double _rayon;

        public Cercle(double rayon)
        {
            this._rayon = rayon;
        }

        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }

        public double CalculeAire()
        {
            double aire = Math.PI * Math.Pow(_rayon, 2);

            return aire;
        }

        public double CalculePerimetre()
        {
            double perimetre = 2 * Math.PI * _rayon;

            return perimetre;
        }

        public void Caracteristiques(double perimetre, double aire)
        {
            Console.WriteLine("Le cercle de rayon " + _rayon + " a un périmètre de " + perimetre + " et une aire de " + aire);
        }
    }
}
