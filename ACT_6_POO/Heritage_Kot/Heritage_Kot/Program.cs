using System;

namespace Heritage_Kot
{
    class Program
    {
        static void Main(string[] args)
        {
            Professeur prof = new Professeur("Philosophie", "Kabisa Baptiste", "rue du Lion 1", 1914, "Kinshasa");
            Etudiant etud = new Etudiant(7, "rue de la Déprime 0", "Dupuis Brieux", "rue de l'Enfer 666", 6820, "Namur");
            Employe empl = new Employe(DateTime.Now, "Educateur", "Prestifilippo Gabriel", "rue du Charisme 1", 6820, "Namur");
            string etiquette;
            bool voisin;

            Console.WriteLine(empl.EstVoisin(etud));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(prof.FabriqueEtiq());
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine(etud.FabriqueEtiq());    
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(empl.FabriqueEtiq());
            Console.ReadLine();
        }
    }
}
