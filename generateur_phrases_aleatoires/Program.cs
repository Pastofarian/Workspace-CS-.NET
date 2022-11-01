using System;

namespace generateur_phrases_aleatoire
{
    class Program
    {

        static string ObtenirElementAleatoire(string[] t)
        {
            Random rand = new Random();
            string mot = t[rand.Next(t.Length)];
            return mot;
        }

        static void Main(string[] args)
        {
            //sujet verbe complement
            var sujets = new string[]
            {
                "Un lapin",
                "Une grand mère",
                "Un chat",
                "Un bonhome de neige",
                "Une limace",
                "une fée",
                "Un magicien",
                "Une tortue",
            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "regarde",
                "avale",
                "nettoie",
                "se bat avec",
                "s'accroche à",
            };
            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };


            List<string> phraseUniques = new List<string>();
            const int NB_PHRASES = 100;
            int doublonsEvite = 0;

            while(phraseUniques.Count < NB_PHRASES)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                var phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");
                

                if (!phraseUniques.Contains(phrase))
                {
                    //phraseUnique.Remove(phrase);
                    phraseUniques.Add(phrase);
                }
                else
                {
                    doublonsEvite++;
                    //NB_PHRASES++ autre solution en changeant la const en variable
                }
            }
            Console.WriteLine("Nombre de phrases uniques : " + phraseUniques.Count);
            Console.WriteLine("Nombre de doublons évités : " + doublonsEvite);
            foreach(string phrase in phraseUniques)
            {
                Console.WriteLine(phrase);
            }


        }
    }
}