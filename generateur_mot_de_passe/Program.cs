using System;

namespace generateur_mot_de_passe
{
    internal class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
            //int nombre = DemanderNombre(question);
            //if(nombre > 0)
            //{
            //    return nombre;
            //}
            //Console.WriteLine("ERREUR : Le nombre doit être supérieur à 0");
            //return DemanderNombrePositifNonNul(question);
        }
        static int DemanderNombreEntre(string question, int min, int max)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            Console.WriteLine("Vous devez entrer un nombre entre " + min + " et " + max);
            return DemanderNombreEntre(question, min, max);
        }
        static int DemanderNombre(string question)
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
                }
            }
        }
        static void Main(string[] args)
        {
            DemanderNombreEntre("Entrez un nombre entre ", 1, 10);
        }
    }
}