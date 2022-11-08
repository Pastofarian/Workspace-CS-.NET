using System;
using System.Security.Cryptography.X509Certificates;

namespace progamme_fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = "out";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path); // pour créer un répertoire

            }

            string filename = "monFichier.txt";

            string pathAndFile = Path.Combine(path, filename); // pour que ce soit crossplatform \\windows //linux

            if (File.Exists(pathAndFile))
            {
                Console.WriteLine("Le fichier existe déjà, on va écraser son contenu.");
            }
            else
            {
                Console.WriteLine("Le fichier n'existe pas, on va le créer.");
            }


            Console.WriteLine("FICHIER : " + pathAndFile);

            /*var noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Martin"
            };*/

            string texte = "";
            int nbLignes = 20000;

            for(int i = 1; i < nbLignes; i++)
            {
                texte = "Ligne " + i;
            }

            Console.Write();
            File.WriteAllLines(pathAndFile, texte); //AllLines et AllText est le même
            //File.WriteAllText("monFichier.txt", "Voici le contenu que j'écris dans mon fichier texte"); //crée et écrase le fichier
            //File.AppendAllText(filename, "je rajoute ce texte.");

            try
            {
                //string resultat = File.ReadAllText(filename);
                var lignes = File.ReadAllLines(pathAndFile);

                foreach (var ligne in lignes)
                {
                    Console.WriteLine(ligne);  
                }
                
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ERREUR : ce fichier n'existe pas (" + ex.Message + ")");
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivée");
            }
        }
    }
}