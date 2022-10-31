using System;

namespace programme_collections
{
    internal class Program
    {
        static int SommeTableau(int[] t)
        {
            int somme = 0;
            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }
            return somme;

        }
        static void AfficherTableau(int[] tableau)
        {
            for(int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "]" + " " + tableau[i]);
            }        
        }

        static void AfficherValeurMaximale(int[] t)
        {
            int max = t[0];    
            for(int i = 0; i < t.Length; i++)
            {
                if(t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximale est : " + max);
        }
        static void Tableaux()
        {

            //int[] t = { 200, 40, 15, 8, 12 };
            const int TAILLE_TABLEAU = 20;

            int[] t = new int[TAILLE_TABLEAU];

            Random rand = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rand.Next(101);
            }
            AfficherTableau(t);
            AfficherValeurMaximale(t);


            //Tableaux
            //int[] t = new int[3];
            //t[0] = 2;
            //t[1] = 4;
            //t[2] = 1;
            //t[2]++;

            //syntaxe correcte à l'initialisation
            //int[] t = { 2, 4, 1 };

            /*string[] t = { "Martin", "Emilie", "Paul" };
            string premierNom = t[0];
            Console.WriteLine(premierNom[0]); // Pour afficher le "M" de Martin
            //ou aussi 
            Console.WriteLine(t[0][1]); // Pour afficher le "a" de Martin

            for(int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }*/

            //Console.WriteLine("sommeTableau : " + SommeTableau(t));
        }
        static void Main(string[] args)
        {
            Tableaux();
            


        }
    }
}