using System;
using System.Collections.Generic;
using System.Text;

namespace Nombre_Complexe
{
    class Complexe
    {
        private double _a;
        private double _b;

        public Complexe(double a, double b)
        {
            this._a = a;
            this._b = b;
        }

        public double A
        {
            get { return _a; }
            set { _a = value; }
        }

        public double B
        {
            get { return _b; }
            set { _b = value; }
        }

        public void AfficheComplexe(double module, int numeroCom)
        {
            string message = "";

            switch (numeroCom)
            {
                case 1:
                    message = "Le premier complexe : (";
                    break;

                case 2:
                    message = "Le deuxième complexe : (";
                    break;
            }

            message = message + _a.ToString("f2") + "," + _b.ToString("f2") + ") a pour module : " + module.ToString("f2");

            Console.WriteLine(message);

        }

        public double CalculeModule()
        {
            double module = Math.Sqrt(Math.Pow(_a, 2) + Math.Pow(_b, 2));

            return module;
        }

        public void Ajoute(Complexe nbrCom2)
        {
            _a += nbrCom2._a;
            _b += nbrCom2._b;

            Console.WriteLine("Le premier complexe devient : (" + _a.ToString("f2") + "," + _b.ToString("f2") + ") après l'ajout du second:");
        }
    }
}
