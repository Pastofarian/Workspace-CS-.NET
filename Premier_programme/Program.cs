using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace premier_programme
{
    internal class Program
    {
        static int DemanderAge(string nom)
        {
            int ageNum = 0;
            while (ageNum <= 0)
            {
                Console.Write(nom + ", quel est ton age ? ");
                string ageStr = Console.ReadLine();

                try
                {
                    ageNum = int.Parse(ageStr);

                    if (ageNum < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif.");
                    }
                    if (ageNum == 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être égal à zéro.");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur: vous devez rentrer un age valide.");
                }
            }
            return ageNum;
        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim(); //supprime les espaces 

                if (nom == "")
                {
                    Console.WriteLine("Erreur : Entrez un nom");
                }
            }
            return nom;
        }

        static void AfficherInfoPersonne(string nom, int age, float taille = 0) //assigne 0 et le parametre devient optionel, toujours en dernier
        {
            Console.WriteLine();
            Console.WriteLine($"Vous vous appelez {nom}, \nvous avez {age} ans"); //autre facon de noter les variables ${}
            Console.WriteLine("Bientôt il aura " + (age + 1) + " ans");


            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }
            else if (age == 1 || age == 2)
            {
                Console.WriteLine("Vous êtes un bébé");
            }
            else if (age >= 12 && age < 18)
            {
                Console.WriteLine("Vous êtes un adolescent");
            }
            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes senior");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
            if (taille != 0)
            {
                Console.WriteLine("Vous faites " + taille + "m de hauteur.");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //DEMANDE LE NOM
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);


            //DEMANDE L'AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            //AFFICHE LES RESULTATS
            AfficherInfoPersonne(nom1, age1, 1.75f); // ne pas oublier le f pour float
            AfficherInfoPersonne(nom2, age2);

            //const int NB_PERSONNES = 5;

            //for(int  i = 0; i < NB_PERSONNES; i++)
            //{
            //    string nom = "Personne" + (i + 1);
            //    int age = DemanderAge(nom);
            //    AfficherInfoPersonne(nom, age); 
            //    Console.WriteLine();
            //    Console.WriteLine("---");
            //}
        }
    }
}