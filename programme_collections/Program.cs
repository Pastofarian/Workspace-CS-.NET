using System;
using System.Collections;
using System.Collections.Generic;

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
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "]" + " " + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
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

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if (ordreDescendant)
            {
                for (int i = liste.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            string nomLePlusLong = "";
            int max = 0;

            for (int i = 0; i < liste.Count; i++)
            {

                if (liste[i].Length > max)
                {
                    max = liste[i].Length;
                    nomLePlusLong = liste[i];
                }
            }
            Console.Write("Le nom le plus grand est : " + nomLePlusLong);
        }

        static void AfficherElementCommuns(List<string> liste1, List<string> liste2)
        {
            for (int i = 0; i < liste1.Count; i++)
            {
                for (int j = 0; j < liste2.Count; j++)
                {
                    if (liste1[i].Equals(liste2[j]))
                    {
                        Console.WriteLine(liste2[j]);
                    }
                }
            }
        }

        //technique avec contains
        //static void AfficherElementCommuns(List<string> liste1, List<string> liste2)
        //{
        //    for (int i = 0; i < liste1.Count; i++)
        //    {
        //        string nom1 = liste1[i];
        //        if (liste2.Contains(nom1))
        //        {
        //            Console.WriteLine(nom1);
        //        }
        //    }
        //}

        /*
        static void Listes()
        {
            //List<int> liste = new List<int>();

            //liste.Add(5);
            //liste.Add(8);
            //liste.Add(2);

            //liste[2]++;
            //liste.Remove(8); //supprime la première occurence de 8
            //liste.RemoveAt(1); //supprime à l'index 1

            //AfficherListe(liste);

            List<string> noms = new List<string>() {"Jean", "Paul"};//var noms = new List<string>();  c'est équivalent
            while (true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir) : ");
                string nom = Console.ReadLine();

                noms.Contains(nom); //retourne un bool
                if (nom == "")
                {
                    break;
                }
                if (noms.Contains(nom))
                {
                    Console.WriteLine("Erreur, ce nom est déjà dans la liste");
                    Console.WriteLine();
                }
                else
                {
                    noms.Add(nom);
                }

            }
            //List<string> lesPremiersNoms = noms.GetRange(0, 3);

            for (int i = noms.Count - 1; i >= 0; i--) //toujours boucler en partant de la fin quand on utilise remove ou add pour éviter index problems
            {
                
                string nom = noms[i];
                if (nom[nom.Length - 1] == 'e')
                {
                    noms.RemoveAt(nom[i]);
                }
            }

            AfficherListe(noms, true);
        }

            var liste1 = new List<string>() { "Paul", "Jean", "Pierre", "Emilie", "Martin" };
            var liste2 = new List<string>() { "Sophie", "Jean", "Martin", "Toto" };



            AfficherElementCommuns(liste1, liste2);
        }

        static void ArrayList()
        {
            ArrayList a = new ArrayList();
            a.Add("Toto");
            a.Add(49);
            a.Add(true);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            var nom = a[0];
            var age = (int)a[1]; //obligé de faire un cast car age est de type object
            age++;

        }


        static void ListesDeListes()
        {
            /*var villes = new List<string>();  <--List<string>
            villes.Add("France : Paris, Toulouse, Nice, Bordeaux, Lille"); <--List<string>
            villes.Add("Etas-unis : New-York, Chicago, Losangeles, San Fransisco"); <--List<string>
            villes.Add("Espagne : Madrid, Barcelone, Séville"); <--List<string>
            villes.Add("Italie : Venise, Florence, Milan, Pise"); <--List<string>
            AfficherListe(villes);


            var pays = new List<List<string>>();
            pays.Add(new List<string> { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string> { "Etats-unis", "New-York", "Chicago", "Los angeles", "San Francisco" });
            pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise" });

            for (int i = 0; i < pays.Count; i++)
            {
                //var p = pays[i];
                Console.WriteLine(pays[i][0] + " - " + (pays[i].Count - 1) + " villes"); //(p.Count-1) -1 parce que le pays est dans la liste
                for (int j = 0; j < pays[i].Count; j++) //on démarre à 1 car 0 est le pays
                {
                    Console.WriteLine("  " + pays[i][j]);
                }
            }
        }
        
        static void Dictionnaire()
        {
            /*
            string personneAChercher = "Martin";
            
            var d = new Dictionary<string, string>(); //clé =>valeur
            d.Add("Jean", "062586325");
            d.Add("Marie", "062584564");
            d["Martin"] = "0655485444"; //autre façon de faire

            if(d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]); //Pas besoin de boucler avec les dictionnaires ! bcp plus rapide!!

            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée");
            }
            Console.WriteLine(d["Marie"]);
            
            var l = new List<string[]>();
            l.Add(new string[] { "Jean", "0658412214" });
            l.Add(new string[] { "Marie", "0658454556" });
            l.Add(new string[] { "Martin", "065454454" });
            l.Add(new string[] { "Toto", "06587458254" });

            for(int i = 0; i < l.Count; i++)
            {
                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }
            
        }
        static void BoucleForEach()
        {
            /*
            //var noms = new string[] { "Toto", "Jean", "Pierre" }; // tableau
            var noms = new List<string>() { "Toto", "Jean", "Pierre" }; //liste

            foreach (string s in noms)
            {
                Console.WriteLine(s);
            }

            var d = new Dictionary<string, string>(); //clé =>valeur
            d.Add("Jean", "062586325");
            d.Add("Marie", "062584564");
            d["Martin"] = "0655485444"; //autre façon de faire

            foreach (var e in d)
            {
                Console.WriteLine(e.Key + " -> " + e.Value);
            }
        }*/
            static void TrisEtLinq()
            {
            //var noms = new List<string>() { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };
            //var noms = new string[] { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };


            //noms.Sort(); // pour une liste
            //Array.Sort(noms); //pour tableau


            //var nomsTries = noms.OrderBy(nom => nom.Length); // OrderBy(nom => nom[nom.Length-1]); Pour trier par la dernière lettre
            //noms = noms.OrderBy(nom => nom).ToList(); // pour écraser la variable il faut ajouter une convertion .ToList();
            //noms = noms.Where(nom => nom.Length > 4).ToList(); // trie les éléments supérieur à 4
            //noms = noms.Where(nom => nom[nom.Length-1] == 'e').ToList();
            /*
            foreach (var nom in noms)
                {
                    Console.WriteLine(nom);
                }*/

            var notes = new List<int>() { 1, 20, 31, 44, 75, 16 };
            //notes = notes.OrderBy(n => -n).ToList();
            notes = notes.Where(n => n >= 30).ToList();
            foreach (var n in notes)
            {
                Console.WriteLine(n);
            }


            static void MaFonction(out int p)
            {
                p = 10;
            }

            static void MaFonction2(List<int> p)
            {
                p[0] = 10;
            }

            static void PassageValeursOuRef()
            {
                //int a = 5;
                //MaFonction(out a); // Passage par référence

                //int num = int.Parse("abdhdjf");
                int num = 0;
                if (int.TryParse("aaaass", out num))
                {
                    Console.WriteLine("Conversion OK");
                    num++;
                }
                else
                {
                    Console.WriteLine("Problème de Conversion");
                }


                //var l = new List<int> { 5 };
                //MaFonction2(l); // Passage par reference

                //Console.WriteLine(l[0]);
                Console.WriteLine(num);
            }
            static void Main(string[] args)
            {
                //Les tableaux ont une limite de taille définie
                //Tableaux();
                //Les listes n'ont pas de limite de taille
                //Listes();
                //On peut stocké différent type dans une arrayList (très peu utilisé car mixer des types c'est pas top)
                //ArrayList();
                //Une liste dans une liste ou un tableau dans une liste est possible
                //ListesDeListes();
                //Les dictionnaires sont plus rapide que les listes ou les tableaux, association clé -> valeur
                //Dictionnaire();
                //BoucleForEach();
                TrisEtLinq();
            }
        }

    }