using System;

namespace exo_pierre_papier_ciseaux
{
    class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("PIERRE - PAPIER - CISEAUX");
            Console.ReadLine();
            Console.Clear(); 
            Console.WriteLine(@"Veuillez choisir une des propositions :
    1) Pierre 
    2) Papier 
    3) Ciseaux");
            string input = Console.ReadLine();
            bool isConverted = int.TryParse(input, out int user_choice);
            if (isConverted && user_choice >=1 && user_choice <= 3)
            {
                int cpu_choice = RNG.Next(1, 4);

                if(cpu_choice == user_choice)
                {
                    Console.WriteLine("Egalité...");
                }
                else if (
                    (user_choice == 1 && cpu_choice == 3) ||
                    (user_choice == 2 && cpu_choice == 1) ||
                    (user_choice == 3 && cpu_choice == 2)
                    )
                {
                    Console.WriteLine("Felicitation! La fore est avec toi !");
                }
                else
                {
                    Console.WriteLine("Quel dommage , vous avez perdu..");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Apprends à lire avant de venir jouer!");
            }
        }
    }
}
