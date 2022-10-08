using System;

internal class Program
{
    static void Main(string[] args)
    {
        Pendu pendu1 = new Pendu("i love csharp");

        while(pendu1.IsFullyUnhidden() == false && pendu1.IsLost() == false)
        {
            Console.WriteLine("Entrez un caratère, vous avez droit à 5 erreurs");
            char input = Console.ReadKey().KeyChar; //fonction pour détecter une entrée clavier
            if (pendu1.Attempt(input))
            {
                Console.WriteLine();
                Console.WriteLine("Bravo vous avez trouvé");
            }
            
            Console.WriteLine();
            Console.WriteLine(pendu1);
        }
        if(pendu1.IsFullyUnhidden() == true)
        {
            Console.WriteLine();
            Console.WriteLine("Vous avez gagné, le mot était bien : " + pendu1);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Vous avez perdu !");
        }
    }
}