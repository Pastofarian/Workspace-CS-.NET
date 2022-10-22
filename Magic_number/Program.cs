using System;

namespace magic_number
{
    internal class Program
    {

        static int DemanderNombre(int min, int max)
        {
            int magicNum = min - 1;

            while (magicNum < min || magicNum > max)
            {
                Console.Write("Entrez un nombre entre " + min + " et " + max + " : ");
                string stringNum = Console.ReadLine();

                try
                {
                    magicNum = int.Parse(stringNum);

                    if (magicNum < min || magicNum > max)
                    {
                        Console.WriteLine("Erreur : le nombre doit être entre " + min + " et " + max);
                        magicNum = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur : vous devez entrer un nombre valide.");
                }
            }

            return magicNum;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int nombre_magique = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int essai = NOMBRE_MIN - 1;

            for(int nbVies = 4; nbVies > 0; nbVies--)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                essai = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (essai > nombre_magique)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else if (essai < nombre_magique)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else
                {
                    Console.WriteLine("Bravo, vous avez le nombre magique !");
                    break;
                }
            }
            if (essai != nombre_magique)
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était : " + nombre_magique);
            }
        }
    }
}