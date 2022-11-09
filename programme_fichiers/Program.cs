using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
            string filename2 = "monFichier.txt";


            string pathAndFile = Path.Combine(path, filename); // pour que ce soit crossplatform \\windows //linux
            string pathAndFile2 = Path.Combine(path, filename2); 


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

            // immutable
            //texte = "toto";
            //texte += "o"; //totoo

            //mutable
            //StringBuilder

            StringBuilder texte = new StringBuilder();
            //string texte = "";
            int nbLignes = 10000000;

            /***************************************************************************************************/
            /*DateTime t1 = DateTime.Now;
            Console.WriteLine("Préparation des données... ");
            for(int i = 1; i < nbLignes; i++)
            {
                texte.Append("Ligne " + i + "\n");
            }

            Console.WriteLine("OK");

            Console.WriteLine("Ecriture des données ...");
            File.WriteAllText(pathAndFile, texte.ToString()); //AllLines et AllText est le même sauf si on utilise StringBuilder 
            Console.WriteLine("OK");

            DateTime t2 = DateTime.Now;
            var diff = (int)(t2 - t1).TotalMilliseconds;   //1s = 1000ms
            Console.WriteLine("Durée (ms)" + diff);*/
            /*******************************************************************************************************/

            //Stream : flux //Pour écrire des très gros fichers !
            //using (variable...) {...code ... } pour alouer la mémoire et la libérer à la fin de l'instruction

            DateTime t1 = DateTime.Now;
            Console.WriteLine("Ecriture des données... ");
            using (var writeStream = File.CreateText(pathAndFile)) 
            {
                for (int i = 1; i < nbLignes; i++)
                {
                    writeStream.Write("Ligne " + i + "\n");
                }
            }
            Console.WriteLine("OK");
            DateTime t2 = DateTime.Now;
            var diff = (int)(t2 - t1).TotalMilliseconds;   //1s = 1000ms
            Console.WriteLine("Durée (ms)" + diff);

            //Lecture avec un stream
            using (var readStream = File.OpenText(pathAndFile))
            {
                while(true)
                {
                    var line = readStream.ReadLine();
                    if(line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }
            }





            //File.WriteAllText("monFichier.txt", "Voici le contenu que j'écris dans mon fichier texte"); //crée et écrase le fichier
            //File.AppendAllText(filename, "je rajoute ce texte.");

            try
            {
                //string resultat = File.ReadAllText(filename);
                var lignes = File.ReadAllLines(pathAndFile); //il met en mémoire le fichier en une fois (out of memory)!

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
            //File.Copy(pathAndFile, pathAndFile2);
            //File.Delete(pathAndFile2);
            File.Move(pathAndFile, pathAndFile2); //sert à déplacer ou à renomer 
        }
    }
}