using System;

namespace delegates
{
    internal class Program
    {
        public delegate string ValidationChaine(string s); //ValidationChaine est un type
        static void Main(string[] args)
        {
            string nom = DemanderChaineUtilisateur("Quel est votre nom ?", CheckValidationNom);

            //0610101010 -> 10 chiffres
            string tel = DemanderChaineUtilisateur("Quel est votre numéro de téléphone ?", CheckValidationTel);

            Console.WriteLine();
            Console.WriteLine("Bonjour " + nom + ", vous êtes joignable au " + tel);

        }
        static string DemanderChaineUtilisateur(string message, ValidationChaine fonctionValidation = null) //fonctionValidation est un paramètre optionnel
        {
            Console.Write(message + " ");
            string reponse = Console.ReadLine();
            if (fonctionValidation != null)
            {
                string erreur = fonctionValidation(reponse);
                if (erreur != null)
                {
                    Console.WriteLine("ERREUR : " + erreur);
                    return DemanderChaineUtilisateur(message, fonctionValidation);
                }
            }
            return reponse;
        }
        static string CheckValidationNom(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return "Le nom ne doit pas être vide";
            }
            if (s.Any(char.IsDigit))
            {
                return "Le nom ne doit pas contenir de chiffres";
            }
            return null;
        }

        static string CheckValidationTel(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return "Le numéro de téléphone ne doit pas être vide";
            }
            if (s.Length != 10)
            {
                return "Le numméro de téléphone doit contenir 10 chiffres";
            }
            if (!s.All(char.IsDigit))
            {
                return "Le numéro de téléphone doit contenir uniquement des chiffres";
            }
            return null;
        }
    }
}
