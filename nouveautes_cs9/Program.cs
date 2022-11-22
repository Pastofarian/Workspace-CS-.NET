using System;

namespace nouveautes_cs9
{
    //Une structure est bien pour comparer des champs ou pou dupliquer des objets avec les même champs. mais pas d'héritage, pas de constructeur par défault, cas particulier très peu de données - moins de 16octets. Sauvegarde dans la stack (mémoire)
    struct PersonneStruct
    {
        public string nom
        {
            get; set; //init = initier la valeur uniquement à la construction de l'objet
        }
        public int age
        {
            get; set;
        }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }

    /*record PersonneRecord
    {
        public string nom
        {
            get; init; //init = initier la valeur uniquement à la construction de l'objet
        }
        public int age
        {
            get; init;
        }

        public PersonneRecord(string nom, int age)
        {
            this.nom = nom;
            this.age = age;
        }

        public void Deconstruct(out string nom, out int age)
        {
            nom = this.nom;
            age = this.age;
        }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }*/

    //Immutable
    record PersonneRecord(string nom, int age); //équivalent du code record juste au dessus (constructeur et deconstructeur)

    record PersonneRecordAffichable : PersonneRecord
    {
        public PersonneRecordAffichable(string nom, int age) : base(nom, age)
        {
        }
        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
    }

    //Class est mutable
    class PersonneClass
    {
        public string nom
        {
            get; set; //init = initier la valeur uniquement à la construction de l'objet
        }
        public int age
        {
            get; set;
        }

        public void Afficher()
        {
            Console.WriteLine("nom: " + nom + " - age: " + age + " ans");
        }
        //une class n'est pas fait pour tester l'égalité des champs ni pour dupliquer un objet avec les même champs
        /*public override bool Equals(object? obj) // surcharge de la fonction Equals qui fonctionne pour Struct pour comparer les champs
        {
            PersonneClass objetAComparer = (PersonneClass)obj;
            if ((nom == objetAComparer.nom) && (age == objetAComparer.age)) return true;

            return false;   
            //return base.Equals(obj);
        }*/

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var personne1 = new Personne() { nom = "Toto", age = 20 }; // pas besoin de constucteur avec cette syntaxe
            //personne1.nom = "Tata";
            //personne1.Afficher();

            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg); //afficher les arguments entré via la console
            //}

            /*int a = 5; // int est un type valeur
            int b = 10;

            b = a;
            a = 6;

            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + b);*/

            var personne1 = new PersonneClass() { nom = "Toto", age = 20 }; //Class = type référence
            var personne2 = new PersonneClass() { nom = "Toto", age = 20 }; //Class = type référence

            personne1.nom = "Tata";

            personne1.Afficher();
            personne2.Afficher();
            //Renvoie
            //nom: Tata - age: 20 ans
            //nom: Tata - age: 20 ans

            Console.WriteLine(personne1.Equals(personne2)); //false parce que les adresses des objets ne sont pas les mêmes

            var personne3 = new PersonneStruct() { nom = "Toto", age = 20 }; //Struct = type valeur
            var personne4 = personne3;

            personne3.nom = "Tata";

            personne3.Afficher();
            personne4.Afficher();
            //renvoie
            //nom: Tata - age: 20 ans
            //nom: Toto - age: 20 ans

            Console.WriteLine(personne3.Equals(personne4)); //False

            var personne5 = new PersonneRecord("Toto", 20); //Record est un référence type mais permet d'avoir certaine fonctionnalités comme tester les égalités
            var personne6 = personne5 with { nom = "Tata" }; //with permet de cloner le record et d'avoi deux record séparé

            personne5.Afficher();
            personne6.Afficher();

            Console.WriteLine(personne5.Equals(personne6));

            /* Types simples (int, float, char...) -> Value Type (valeur)
            * structures -> Value Type (valeur = les valeurs des champs)
            * class -> Reference Type (valeur = adresse de l'objet)
            * List<string> -> Reference Type (valeur = adresse de l'objet)
            */

            var personne7 = new PersonneRecordAffichable("Toto", 20);
            Console.WriteLine("nom :" + personne7.nom);

            var (nom, age) = personne7; //syntaxe de facilité

            personne7.Afficher();

        }
    }
}