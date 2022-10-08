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
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NOMBRE_MAGIQUE = 5;

            int essai = NOMBRE_MIN - 1;

            while (essai != NOMBRE_MAGIQUE)
            {
                essai = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (essai > NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else if (essai < NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
            }
            Console.WriteLine("Bravo, vous avez le nombre magique !");
        }
    }
}