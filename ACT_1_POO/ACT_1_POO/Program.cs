using System;

namespace ACT_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            double average;

            string tp = "";

            chien[] Hund = new chien[3];

            for (int i = 0; i < Hund.Length; i++)
            {
                Console.WriteLine("Entrez le nom du chien");
                string nomChien = Console.ReadLine();

                uint ageChien;
                do
                {                    
                    Console.WriteLine("Entrez l'age du chien");
                    tp = Console.ReadLine();
                }while (!uint.TryParse(tp, out ageChien));
                
                Console.WriteLine("Entrez la race du chien");
                string raceChien = Console.ReadLine();

                Hund[i] = new chien(nomChien, ageChien, raceChien);
                Hund[i].AfficheCaracteristiques();
            }

            average = Moyenne(Hund);
            Console.WriteLine("La moyenne des âge est : " + average);

            static double Moyenne(chien[] Hund)
            {
                double average = 0;
                int somTotale = 0;
                int age = 0;

                for (int i = 0; i < Hund.Length; i++)
                {
                    age = Hund[i].Age();
                    somTotale = somTotale + age;
                }

                average = (int)somTotale / Hund.Length;

                return average;
            }
        }
    }
}