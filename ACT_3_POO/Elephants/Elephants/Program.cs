using System;

namespace Elephants
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant zazou = new Elephant("Zazou Ramsamy", 40);
            Elephant titi = new Elephant("Titi Grootaers", 20);

            string interaction;
            do
            {
                Console.WriteLine("Which interaction do you want to do? 1 : Show Zazou, 2 : Show Titi, 3 : Switch the datas, stop : Stop the program");
                Console.WriteLine("1 : Show Zazou,");
                Console.WriteLine("2 : Show Titi, ");
                Console.WriteLine("3 : Switch the datas, ");
                Console.WriteLine("stop : Stop the program");
                Console.WriteLine();
                interaction = Console.ReadLine();

                if(interaction != "stop")
                {
                    string showInformations = "";

                    switch (interaction)
                    {
                        case "1":
                            showInformations = zazou.ShowWhoIAm();
                            Console.WriteLine(showInformations);
                            
                            break;

                        case "2":
                            showInformations = titi.ShowWhoIAm();
                            Console.WriteLine(showInformations);
                            
                            break;

                        case "3":
                            SwitchInformations(ref zazou, ref titi);
                            Console.WriteLine("Informations have been switched :");
                            
                            showInformations = zazou.ShowWhoIAm();
                            Console.WriteLine(showInformations);
                            
                            showInformations = titi.ShowWhoIAm();
                            Console.WriteLine(showInformations);
                            
                            break;

                        default:
                            Console.WriteLine("You must choose a correct interaction");
                            
                            break;

                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                
                 
            } while (interaction != "stop");
        }
        static void SwitchInformations(ref Elephant zazou, ref Elephant titi)
        {
            Elephant tempInfos = zazou;
            zazou = titi;
            titi = tempInfos;
        }
    }
}