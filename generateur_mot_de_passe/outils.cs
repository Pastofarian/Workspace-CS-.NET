using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : le nombre doit être positif et non null");
            //int nombre = DemanderNombre(question);
            //if(nombre > 0)
            //{
            //    return nombre;
            //}
            //Console.WriteLine("ERREUR : Le nombre doit être supérieur à 0");
            //return DemanderNombrePositifNonNul(question);
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnalise = null)
        {
            // nombre = DemanderNombre(question)
            // si le nombre est bien entre min et max -> ERREUR / boucler ...

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            if(messageErreurPersonnalise == null)
            {
                Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);

            } else
            {
                Console.WriteLine(messageErreurPersonnalise);
            }
            Console.WriteLine("");

            return DemanderNombreEntre(question, min, max, messageErreurPersonnalise) ;
        }
        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();
                try
                {
                    int answerInt = int.Parse(answer);
                    return answerInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.WriteLine("");
                }
            }
        }
    }
}
