using System.ComponentModel.DataAnnotations;
using System.Collections;


internal class Program
{
    static int nbrPremier(int n)
    {

        //2.Utilisez une fonction pour calculer les nombres premiers dans les 2 boucles de l’exercice des collections.

        Console.Write("Encodez un nombre : ");
        if (int.TryParse(Console.ReadLine(), out int nbinf))
        {
            List<int> listEntier = new List<int>();

            int num = 0;
            int count;

            Console.Write("Les nombres premiers entre 1 et " + nbinf + " sont : \n");

            for (int i = 1; num <= nbinf; num++)
            {
                count = 0;

                for (int j = 2; j <= num / 2; j++)
                {
                    if (num % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && num != 1 && num != 0)
                {
                    return num;
                }
            }

        }

    }
}
}
