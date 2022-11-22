using System;

namespace Nombre_Complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInput;
            string tryA;

            double bInput;
            string tryB;

            int numeroCom;

            string refaire = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenue dans ce programme sur les complexes !");

                Console.WriteLine("Que vaut la partie réelle du complexe de départ?");
                do
                {
                    tryA = Console.ReadLine();
                } while (!double.TryParse(tryA, out aInput));

                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ?");
                do
                {
                    tryB = Console.ReadLine();
                } while (!double.TryParse(tryB, out bInput));

                Complexe nbrCom1 = new Complexe(aInput, bInput);

                numeroCom = 1;
                double module = nbrCom1.CalculeModule();
                nbrCom1.AfficheComplexe(module, numeroCom);

                Console.WriteLine("Encodez un second nombre complexe");
                Console.ReadLine();

                Console.WriteLine("Que vaut la partie réelle du second complexe?");
                do
                {
                    tryA = Console.ReadLine();
                } while (!double.TryParse(tryA, out aInput));

                Console.WriteLine("Que vaut la partie imaginaire du second complexe?");
                do
                {
                    tryB = Console.ReadLine();
                } while (!double.TryParse(tryB, out bInput));

                Complexe nbrCom2 = new Complexe(aInput, bInput);

                numeroCom = 2;
                module = nbrCom2.CalculeModule();
                nbrCom2.AfficheComplexe(module, numeroCom);

                nbrCom1.Ajoute(nbrCom2);

                Console.WriteLine("Un autre test ? (Tapez sur espace)");
                refaire = Console.ReadLine();
            } while (refaire == " ");
           
            Console.ReadLine();
        }
    }
}
