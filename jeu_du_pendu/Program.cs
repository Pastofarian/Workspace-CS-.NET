using System;
using System.Xml.Linq;
using AsciiArt;

namespace jeu_du_pendu
{
    class Program
    {

        static void AfficherMot(string mot, List<char> lettres)
        {
            for (int i = 0; i < mot.Length; i++)
            {
                char c = mot[i];

                if (lettres.Contains(c))
                    Console.Write(c + " ");
                else
                    Console.Write("_ ");
                //same without contains
                //    for (int j = 0; j < lettres.Count; j++)
                //{
                //    if (c == lettre[j])
                //        Console.Write(lettre[j] + " ");
                //    else
                //        Console.Write("_ ");
                //}
            }

        }
        static bool ToutesLettresDevinees(string mot, List<char> lettres)
        {
            foreach (char c in lettres)
            {
                mot = mot.Replace(c.ToString(), "");
            }
            if (mot.Length == 0)  //if (string.IsNullOrEmpty(mot))
            {
                return true;
            }
            return false;
        }
        static char DemanderUneLettre()
        {
            //char input;
            //Console.Write("Entrez une lettre : ");
            //bool flag = Char.TryParse(Console.ReadLine(), out input);
            //if (flag)
            //    return input;
            //else
            //    Console.WriteLine("Vous devez entrez une seule lettre");
            //return DemanderUneLettre();

            Console.Write("Rentrez une lettre : ");
            string reponse = Console.ReadLine();
            if (reponse.Length == 1)
            {
                reponse = reponse.ToUpper();
                return reponse[0];
            }
            Console.WriteLine("ERREUR : Vous devez rentrer une lettre");
            return DemanderUneLettre(); //appel récursif ou boucle while(true)
        }
        static void DevinerMot(string mot)
        {
            const int NB_OF_LIFES = 6;
            int lifes = NB_OF_LIFES;
            var lettreDevinees = new List<char>();
            var missedletter = new List<char>();

            while (lifes > 0)
            {

                Console.WriteLine(Ascii.PENDU[NB_OF_LIFES - lifes]);
                Console.WriteLine();

                AfficherMot(mot, lettreDevinees);
                Console.WriteLine();
                Console.WriteLine();
                char l = DemanderUneLettre();
                Console.Clear();

                if (mot.Contains(l))
                {
                    Console.WriteLine("Cette lettre est dans le mot");
                    lettreDevinees.Add(l);
                    //Gagné
                    if (ToutesLettresDevinees(mot, lettreDevinees))
                    {
                        break;
                    }
                }
                else
                {
                    if (!missedletter.Contains(l))
                    {
                        missedletter.Add(l);
                        lifes--;
                    }
                }
                if(missedletter.Count > 0)
                {
                    Console.WriteLine("Le mot ne contient pas les lettres : " + String.Join(", ", missedletter));
                }
                Console.WriteLine("Vies restantes " + lifes);
                Console.WriteLine();
            }

            Console.WriteLine(Ascii.PENDU[NB_OF_LIFES - lifes]);

            if (lifes == 0)
            {
                Console.WriteLine("PERDU ! Le mot était : " + mot);
            }
            else
            {
                AfficherMot(mot, lettreDevinees);
                Console.WriteLine();

                Console.WriteLine("GAGNE !");
            }
        }

        static string[] ChargerLesMots(string nomFichier)
        {
            try
            {
                return File.ReadAllLines(nomFichier);
            }
            catch(Exception ex) // permet de custom le message d'erreur
            {
                Console.WriteLine("Erreur de lecture du fichier : " + nomFichier + " (" + ex.Message);
            }

            return null;
        }
        static void Main(string[] args)
        {

                var mots = ChargerLesMots("mots.txt");
            if((mots ==null) || (mots.Length == 0)) //gère l'exeption du fichier non existant, misspelled ou empty
            {
                Console.WriteLine("La liste de mots est vide ou non existante");
            }
            else
            {
                Random rand = new Random();
                int r = rand.Next(mots.Length); //quand c'est un tableu [] = .Length / List<> = .Count()
                string mot = mots[r].Trim().ToUpper(); //Trim = nettoie les espaces vide à la fin des mots / ToUpper = on s'assure que le mot soit en majuscule!
                DevinerMot(mot);
            }

            Console.Clear();
            Console.WriteLine("Voulez-vous rejouer (o/n)");
            
            while (Console.ReadKey().Key != ConsoleKey.N)
            {

                    Random rand = new Random();
                    int r = rand.Next(mots.Length); 
                    string mot = mots[r].Trim().ToUpper(); 
                    DevinerMot(mot);
                Console.Clear();
                Console.WriteLine("Voulez-vous rejouer (o/n)");
            }
            
            Console.WriteLine("Merci et à bientôt.");
        }
    }
}