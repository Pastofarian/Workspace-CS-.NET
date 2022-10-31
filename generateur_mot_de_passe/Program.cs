using FormationCS;
using System;
using System.Globalization;

namespace generateur_mot_de_passe
{
    class Program
    {
        enum e_Character
        {
            MINUSCULE = 1,
            MINMAJ = 2,
            CHIFMINMAJ = 3,
            CHARCHIFMINMAJ = 4

        }
        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;

            int longeurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();

            e_Character typeMotDePasse = (e_Character)outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
               // int typeMotDePasse = outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1 - Uniquement des caractères en minuscule \n" +
                "2 - Des caractères minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Caractères, chiffres et caractères spéciaux\n" +
                "Votre choix : ", 1, 4);
            Console.WriteLine("");

            string minuscule = "abcdefghijklmnopqrstuvwxyz";
            string majuscule = minuscule.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "&|@#(^!:/{}°)*-+.=][ù%<>";
            string alphabet;
            

            Random random = new Random();

            //if (typeMotDePasse == 1)
            //    alphabet = minuscule;
            //else if (typeMotDePasse == 2)
            //    alphabet = minuscule + majuscule;
            //else if (typeMotDePasse == 3)
            //    alphabet = chiffres + minuscule + majuscule;
            //else 
            //    alphabet = caracteresSpeciaux + chiffres + minuscule + majuscule;

            switch (typeMotDePasse)
            {
                case e_Character.MINUSCULE:
                    alphabet = minuscule;
                    break;
                case e_Character.MINMAJ:
                    alphabet = minuscule + majuscule;
                    break;
                case e_Character.CHIFMINMAJ:
                    alphabet = chiffres + minuscule + majuscule;
                    break;
                default:
                    alphabet = caracteresSpeciaux + chiffres + minuscule + majuscule;
                    break;
            }

            int longeurAlphabet = alphabet.Length;

            for (int i = 0; i < NB_MOTS_DE_PASSE; i++)
            {
                string motDePasse = "";
                for (int j = 0; j < longeurMotDePasse; j++)
                {
                    int index = random.Next(0, longeurAlphabet); //comme la valeur (min , max) max n'est pas incluse, il ne faut pas faire longeur alphabet-1
                    motDePasse += alphabet[index];
                }
                Console.WriteLine("mot de passe : " + motDePasse);
            }

        }
    }
}