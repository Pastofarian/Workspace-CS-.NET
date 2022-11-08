using System;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace projet_pizza
{
    class PizzaPersonnalisee : Pizza
    {
        static int nbPizzasPersonnalisee = 0;

        public PizzaPersonnalisee() : base("Personnalisée", 5, false, null)
        {
            this.ingredients = new List<string>();
            float supplementPrix = 0;

            nbPizzasPersonnalisee++;
            this.nom = "Personnalisée n° " + nbPizzasPersonnalisee;

            while (true)
            {
                Console.Write("Rentrez un ingrédient pour la pizza personnalisée " + nbPizzasPersonnalisee + " (ENTER pour terminer) :");
                var ingredient = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }
                if (ingredients.Contains(ingredient.ToLower()))
                    Console.WriteLine("ERREUR : Cet ingredient est déjà présent dans la liste.");
                else
                {
                    ingredients.Add(ingredient);
                    supplementPrix += 1.5f;
                }

                Console.WriteLine(string.Join(",", ingredients));
                Console.WriteLine();
            }
            this.prix = prix + supplementPrix;
            //prix = 5 + ingredients.Count * 1.5f;
        }
    }
    class Pizza
    {
        protected string nom;
        public bool vegetarienne
        {
            get; private set;
        }
        public float prix
        {
            get; protected set;
        }
        public List<string> ingredients
        {
            get; protected set;
        }

        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;
        }

        public void Afficher()
        {
            string badgeVegetarienne = vegetarienne ? " (V)" : "";
            string nomAfficher = FormatName(nom);

            var ingredientsAfficher = ingredients.Select(i => FormatName(i)).ToList();
            Console.WriteLine(nomAfficher + badgeVegetarienne + " - " + prix + "€");
            Console.WriteLine(string.Join(",", ingredientsAfficher));
            Console.WriteLine();
        }
        private static string FormatName(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            string minuscules = s.ToLower();
            string majuscules = s.ToUpper();
            string result = majuscules[0] + minuscules[1..];

            return result;
        }

        public bool ContientIngredient(string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //pour le signe €

            var pizzas = new List<Pizza>
            {
                new Pizza("margherita", 9.5f, true, new List<string> { "tomate", "fromage", "olives", "oeufs" }),
                new Pizza("4 saisons", 12.5f, false, new List<string> {"artichauds", "oignons", "tomates" }),
                new Pizza("capricciosa", 14.5f, false, new List<string> { "tomate", "poivron", "oignons", "poulet" }),
                new Pizza("bufalona", 9.0f, true, new List<string> { "tomate", "artichauds", "oignons", "mozzarella", "persil" }),
                new Pizza("calzone", 12.0f, false, new List<string> { "sauce tomate", "poulet", "basilic", "gruyère" }),
                new Pizza("complète", 8.0f, false, new List<string> { "jambon", "ananas", "oignons" }),
                new PizzaPersonnalisee(),
                new PizzaPersonnalisee(),
            };

            //pizzas = pizzas.Where(p => p.vegetarienne is true).ToList();
            //pizzas = pizzas.Where(p => p.ingredients.Where(i => i.ToLower().Contains("tomate")).ToList().Count > 0).ToList(); //where imbriqué
            //pizzas = pizzas.Where(p => p.ContientIngredient("oignon")).ToList(); // avec la methode

            foreach (var pizza in pizzas)
            {
                pizza.Afficher();
            }
        }
    }
}


//pizzas = pizzas.OrderBy(p => p.prix).ToList();
//pizzas = pizzas.OrderByDescending(p => p.prix).ToList();

//tris sans OrderBy

//float min = pizzas[0].prix;
//float max = 0;
//int maxIndex = 0;
//int minIndex = 0;


//for (int i = 0; i < pizzas.Count; i++)
//{
//    if (pizzas[i].prix > max)
//    {
//        max = pizzas[i].prix;
//        maxIndex = i;
//    }
//    if(pizzas[i].prix < min)
//    {
//        min = pizzas[i].prix;
//        minIndex = i;   
//    }
//}

//pizzas[maxIndex].Afficher();
//pizzas[minIndex].Afficher();