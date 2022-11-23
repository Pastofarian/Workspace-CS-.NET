using System.ComponentModel.DataAnnotations.Schema;

namespace cs10_structs
{
    struct PersonneStruct
    {
        public string nom
        {
            get; set;
        }
        public int age
        {
            get; set;
        }
    }
    //public PersonneStruct() //possibilité de surcharger le constructeur en cs10
    //{
    //    nom = "inconnu";
    //    age = -1;
    //}

    //reference / valeur
    //dans le record on peut tester par égaliter toutes les valeurs
    //dans une classe on va tester la référence, impossible de tester l'égalité ==
    //le record^permet aussi de générer rapidement des types avec un constructeur et un déconstructeur
    record class PersonneRecord  //ajout du mot clé class (équivalent à record tout court)
    {
        public string? nom //champ nullable string?
        {
            get; set;
        }
        public int age
        {
            get; set;
        }
    }

    record struct PersonneRecordStruct
    {
        public string? nom //champ nullable string?
        {
            get; set;
        }
        public int age
        {
            get; set;
        }
    }

    readonly record struct PersonneRecordStructReadonly(string nom, int age); //normalement immutable - with { get; init; }

    class Program
    {
        static void Main(string[] args)
        {
            //var ps1 = new PersonneStruct();

            //var pr1 = new PersonneRecord { nom = "Paul", age = 20 };
            //var pr2 = new PersonneRecord { nom = "Paul", age = 20 };

            //Console.WriteLine(pr1 == pr2); //true

            /***************************************/
            //var pr1 = new PersonneRecord { nom = "Paul", age = 20 };
            //var pr2 = pr1;

            //pr1.nom = "Toto";

            //Console.WriteLine(pr2.nom); //Toto parce que Record est un passage par référence, pointe l'adresse de pr1
            //Console.WriteLine(pr1 == pr2); //true
            /******************************************/

            //var pr1 = new PersonneRecordStruct { nom = "Paul", age = 20 };
            //var pr2 = pr1;

            //pr1.nom = "Toto";

            //Console.WriteLine(pr1.nom); //Paul parce que Record est un passage par valeur. se comporte comme struct
            //Console.WriteLine(pr2.nom); //Toto
            //Console.WriteLine(pr1 == pr2); //false

            /*******************************************/

            var pr1 = new PersonneRecordStructReadonly("Toto", 20);
            var pr2 = pr1 with { nom = "Tata" };

            Console.WriteLine(pr1.nom);
            Console.WriteLine(pr2.nom);
            Console.WriteLine(pr1 == pr2);

            string nom1 = "";
            //int age = 0;

            (nom1, var age1) = pr1; //déconstructeur + possibilité de déclarer la variable à l'intérieur
        }
    }
}