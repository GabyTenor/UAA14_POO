using System;

namespace ACT_6_Animaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapin tim = new Lapin("Tim", new DateTime(2022, 08, 01), 68190, 24, true);
            Chien sham = new Chien("Sham", new DateTime(2021, 04, 03), 20341, 50, false);
            Chat scotch = new Chat("Scotch", new DateTime(2013, 01, 20), 19521, 33, false);

            Console.WriteLine(tim.Informations());
            Console.WriteLine(tim.Sleep());
            Console.WriteLine(tim.Jump());
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(sham.Informations());
            Console.WriteLine(sham.Sleep());
            Console.WriteLine(sham.Bark());
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(scotch.Informations());
            Console.WriteLine(scotch.Sleep());
            Console.WriteLine(scotch.Eat());
            Console.WriteLine(scotch.Purr());
            Console.ReadLine();
            Console.Clear();
        }
    }
}
