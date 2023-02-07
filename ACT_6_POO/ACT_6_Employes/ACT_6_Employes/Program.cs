using System;

namespace ACT_6_Employes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe[] personnel = new Employe[] 
            {
                new Ouvrier(001294, "Ramsamy", "Ewan", new DateTime(2005, 04, 23), new DateTime(2022, 03, 10)),
                new Ouvrier(001295, "Leemans", "Nathan", new DateTime(2004, 06, 01), new DateTime(2021, 09, 29)),
                new Ouvrier(001296, "Grootaers", "Romane", new DateTime(2005, 06, 10), new DateTime(2022, 01, 31)),
                new Ouvrier(001297, "Tarnus", "Gabriel", new DateTime(2005, 11, 29), new DateTime(2020, 09, 03)),
                new Ouvrier(001298, "Joly", "Chloé", new DateTime(2004, 10, 31), new DateTime(2022, 09, 15)),
                new Cadre(001299, "Tarnus", "Jeremy", new DateTime(2002, 06, 31), 2),
                new Cadre(001300, "Lepot", "Noé", new DateTime(2004, 12, 06), 4),
                new Cadre(001301, "Feller", "Lenny", new DateTime(2004, 05, 02), 1),
                new Directeur(000001, "Baudson", "Béatrice", new DateTime(1972, 11, 29), 70),
                new Directeur(000002, "Ryckbosch", "Arthur", new DateTime(2005, 09, 11), 30)
            };         
        }
    }
}
