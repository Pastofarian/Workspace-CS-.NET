using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Text;

namespace programme_json
{
    class Personne
    {
        public string nom { get; private set; }
        public int age { get; private set; }
        public bool majeur { get; private set; }

        public Personne(string nom, int age, bool majeur)
        {
            this.nom = nom;
            this.age = age;
            this.majeur = majeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom + " - age: " + age + " ans");
        }

    }

    class Program
    {



        static void Main(string[] args)
        {
            /*var personne1 = new Personne("Toto", 20, true); //{  nom = "Toto", age = 20, majeur = true }; sans passer par constructeur
            personne1.Afficher();

            string json = JsonConvert.SerializeObject(personne1);
            Console.WriteLine(json);

            List<string> noms = new List<string>() { "Jean", "Paul", "Claire" };
            string jsonListe = JsonConvert.SerializeObject(noms);
            Console.WriteLine(jsonListe);

            string jsonTiti = "{\"nom\":\"Titi\",\"age\":15,\"majeur\":false}"; // ajouter un backslash à chaque guillemet
            Personne titi = JsonConvert.DeserializeObject<Personne>(jsonTiti); //operation inverse "deserialize"
            titi.Afficher();*/

            /******************************************Ecriture*****************************************/
            /*var personnes = new List<Personne>();

            personnes.Add(new Personne("Toto", 20, true));
            personnes.Add(new Personne("Titi", 16, false));
            personnes.Add(new Personne("Tata", 75, true));
            personnes.Add(new Personne("Tutu", 7, false));
            var json = JsonConvert.SerializeObject(personnes);
            Console.WriteLine(json);

            File.WriteAllText("personnes.txt", json);*/

            /*********************************************Lecture**********************************/
            var json = File.ReadAllText("personnes.txt");
            var personnes = JsonConvert.DeserializeObject<List<Personne>>(json);

            foreach (var personne in personnes)
            {
                personne.Afficher();
            }

        }
    }
}

//click droit sur l'onglet dépendance => gérer les packages nuget. Puis installer Newtonsoft Json
//Json editor online pour interpreter du format json
//Le Json doir pouvoir accéder aux données soit à travers le constructeur soit par les variables ou les propriétés (get; set;) sinon il ne deserializera pas
//Json ne transporte que des données, pas des fonctions 