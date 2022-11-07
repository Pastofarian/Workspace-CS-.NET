using System;
using System.Linq;

namespace programme_poo
{
    class Enfant : Etudiant
    {
        string classEcole;
        Dictionary<string, float> notes;

        //constructeur
        public Enfant(string nom, int age, string classEcole, Dictionary<string, float> notes) : base(nom, age, null)
        {
            this.classEcole = classEcole;
            this.notes = notes;

        }
        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Enfant en classe de : " + classEcole);
            if ((notes != null) && (notes.Count > 0))
            {
                Console.WriteLine("Notes moyennes: ");
                foreach (var note in notes)
                {
                    Console.WriteLine("    " + note.Key + " : " + note.Value + " /10");
                }
            }
        }

    }
    class Etudiant : Personne //class enfant de la class Personne, elle est héritée
    {
        string infoEtudes;
        public Personne professeurPrincipal;

        //constructeur
        public Etudiant(string nom, int age, string infoEtudes) : base(nom, age, "Etudiant")
        {
            if (infoEtudes != null)
                this.infoEtudes = infoEtudes;
        }
        public override void Afficher() //masque le membre hérité 'Personne.Afficher()' sans le override
        {
            AfficherNomEtAge();
            Console.WriteLine("  Etudiant en " + infoEtudes);
            AfficherProf();
        }
        protected void AfficherProf()
        {
            if (professeurPrincipal != null)
            {
                Console.WriteLine("  Le professeur principal est : ");
                professeurPrincipal.Afficher();
            }
        }
    }

    class Personne : IAffichable
    {

        static int nombreDePersonnes = 0; //la variable (de classe ou static) n'est pas recréée à chaque nouvel objet.

        //variable d'instance
        //public string nom;  public pour pouvoir y accéder depuis le OrderBy mais pas sécurisé! utilisé get/set
        protected string nom; //protected est accessible aussi dans les classes dérivées
        public int age { get; init; }
        string emploi;

        protected int numeroPersonne; //unique à l'objet, recréée à chaque objet

        //constructeurs
        public Personne(string nom, int age, string emploi = null)
        {
            this.nom = nom; //this.nom = variable d'instance / nom = paramètre
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }

        //public Personne(string nom, int age) : this(nom,age, "(Non spécifié)") //autre constructeur, autre façon paramètre optionel
        //{
        //}


        public virtual void Afficher() //virtual permet la surcharge (override) de l'autre fonction Afficher
        {
            AfficherNomEtAge();
            if (emploi != null)
                Console.WriteLine("  EMPLOI : " + emploi);
            else
                Console.WriteLine("  Aucun emploi spécifié");
        }

        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("Nombre total de personnes : " + Personne.nombreDePersonnes);
            //impossible d'accéder à un objet "this" à partir d'une méthode static
        }

        protected void AfficherNomEtAge()
        {
            Console.WriteLine("PERSONNE N°" + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine("  AGE : " + age + " ans");
        }
    }

    class TableMultiplication : IAffichable
    {
        int numero;
        public TableMultiplication(int numero)
        {
            this.numero = numero;
        }

        public void Afficher()
        {
            Console.WriteLine("Table de multiplication de " + numero);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " X " + numero + " = " + i*numero);
            }
        }
    }

    interface IAffichable //Dans l'interface on ne peut mettre que des fonctions
    {
        void Afficher();
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*var noms = new List<string> { "Paul", "Jacques", "David", "Juliette" };
            var ages = new List<int> { 30, 35, 20, 8 };
            var emplois = new List<string> { "Développeur", "Professeur", "Etudiant", "CP" };

            for(int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonnes(noms[i], ages[i], emplois[i]);

            }

            Personne personne1 = new Personne("Paul", 30, "Développeur"); //instancie la class personne pour créer un objet personne dans la variable personne1
            //personne1.Afficher();
            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            //personne2.Afficher();*/


            var elements = new List<IAffichable>   //!! pour ajouter directement à la liste pas de parenthèse !!
            {
                new Personne("Paul", 30, "Développeur"), //avec new on instancie la classe Personne avec un nouvel objet
                new Personne("Jacques", 35, "Professeur"),
                new Etudiant("David", 20, "philo"),
                new Enfant("Juliette", 8, "CP", null), //POLYMORPHISME => le fait de pouvoir utiliser d'autre type dans une List de type Personne
                new TableMultiplication(2)
            };

            //personnes = personnes.OrderBy(p => p.nom).ToList();
            //personnes = personnes.Where(p => p.age >= 25).ToList();
            //personnes = personnes.Where(p => p is Etudiant).ToList();
            //personnes = personnes.Where(p => p.nom[0] == 'J').ToList(); //changer la variable nom protected en public pour accéder à nom
            //personnes = personnes.Where(p => p.nom[0] == 'J')&&(p.age > 30).ToList(); 



            foreach (var element in elements)
            {
                element.Afficher();
            }
            //var tableMultiplication = new TableMultiplication(5);
            //tableMultiplication.Afficher();

     

            //Personne.AfficherNombreDePersonnes();

            //var personne1 = new Personne { nom = "Paul", age = 30, emploi="Ingénieur" }; //on ne passe pas par le constructeur avec des paramètres ici

            //var professeur = new Personne("Jacques", 35, "Professeur"); //Ici on passe par le constructeur

            //var etudiant = new Etudiant("David", 20, "école d'ingénieur en informatique"); 
            //etudiant.professeurPrincipal = new Personne("Jacques", 35, "Professeur");
            //var etudiant = new Etudiant("Jacques", 35, "Etudiant"); //le constructeur n'est pas hérité de la classe Personne!
            //etudiant.Afficher();

            /*var notesEnfant1 = new Dictionary<string, float> { { "Maths", 5f }, { "Géo", 8.5f }, { "Dictée", 2.5f } };
            var enfant = new Enfant("Sophie", 7, "CP", notesEnfant1)
            {
                professeurPrincipal = new Personne("Jean", 39, "Professeur des écoles")
            };
            enfant.Afficher();*/

        }
    }
}