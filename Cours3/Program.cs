

using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cours3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************   Les Boucles    ***********************************************/

            Console.WriteLine("1.Calculer les 25 premiers nombres de la suite de Fibonacci");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            const int max = 25;

            int first = 0;
            int second = 1;
            int third;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < max; i++)
            {
                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
            Console.Write("\n\n");

            /**********************************************************************************************************************/

            Console.WriteLine("2. Calculer le factoriel d’un nombre entré au clavier.");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            int fact = 1;

            Console.Write("Entrez un nombre positif : ");
            bool input1 = int.TryParse(Console.ReadLine(), out int number);
            if (input1)
            {
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("La factoriel de " + number + " est " + fact);
                Console.Write("\n\n");
            }
            else
            {
                Console.WriteLine("NAN");
            }

            /**********************************************************************************************************************/

            Console.WriteLine("3. Grâce à une boucle « for », calculez les x premiers nombre premier.");
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            int num = 0;
            int ctr;
            int input2;


            Console.Write("Entrez la valeur max : ");
            input2 = int.Parse(Console.ReadLine());
            Console.Write("Les nombres premiers entre 1 et " + input2 + " sont : \n");

            for (int start = 1; num <= input2; num++)
            {
                ctr = 0;

                for (int k = 2; k <= num / 2; k++)
                {
                    if (num % k == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");

            /************************ Version avec le nombre de nombre premier ******************/
            //si input2 = 40 => il va me calculer 40 nombres premiers

            int num = 0;
            int index;
            int input2;
            int count = 0;

            Console.Write("Entrez le nombre max : ");
            input2 = int.Parse(Console.ReadLine());
            Console.Write("Les nombres premiers entre 1 et " + input2 + " sont : \n");

            for (int start = 1; num > -1; num++)
            {
                index = 0;

                for (int k = 2; k <= num / 2; k++)
                {
                    if (num % k == 0)
                    {
                        index++;
                        break;
                    }
                }

                if (index == 0 && num != 1)
                {

                    count++;
                    Console.Write("{0} ", num);
                    if (count == input2)
                    {
                        break;
                    }
                }
            }
            Console.Write("\n");


            /**********************************************************************************************************************/

            Console.WriteLine("4. A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».");
            //1x1 = 1 ; 2x1 = 2; ……
            //2x1 = 2; 2x2 = 4; ……
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            for (int l = 1; l <= 5; l++)
            {
                Console.WriteLine($" Table de {l}");
                for (int m = 1; m <= 20; m++)
                {
                    Console.WriteLine($"{l} * {m} = {l * m}");
                }
                Console.WriteLine();
            }

            /*********************************************************************************************************************/

            Console.WriteLine("5.À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.");
            //Remarquez-vous quelque chose de particulier ?
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            for (double o = 0.0; o <= 20.0; o += 0.1F)
            {
                Console.WriteLine($"{o}");
            }

            Console.Write("\n");

            /******************** Format decimal*************************/

            for (decimal o = 0; o <= 20; o += 0.1M)
            {
                Console.WriteLine($"{o}");
            }

            Console.Write("\n");
            /*********************************************************************************************************************/

            Console.WriteLine("6. Bonus : Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse),// See using System;");
            //Remarquez-vous quelque chose de particulier ?
            Console.Write("---------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Racine carrée de 25 (Integer) avec Math.Sqrt(): " + Math.Sqrt(25));
            //double Sqrt(double d);
            Console.Write("\n\n");

            Console.Write("Entrez un nombre : ");
            int val = Convert.ToInt32(Console.ReadLine());
            double root = 1;
            int p = 0;
            //The Babylonian Method for Computing Square Roots
            while (true)
            {
                p = p + 1;
                root = (val / root + root) / 2;
                if (p == val + 1) { break; }
            }
            // Console.WriteLine("Racine carrée sans Math.Sqrt() : {0}", Math.Round(root, 10));
            Console.WriteLine($"Racine carrée sans Math.Sqrt() : {root:0.0000000000}");

            Console.WriteLine();

            /******************************   Les Collections    ********************************************/

            Console.WriteLine("1.Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.");
            Console.WriteLine();

            Console.Write("Encodez un nombre : ");
            if (int.TryParse(Console.ReadLine(), out int nbinf))
            {

                var arlist = new ArrayList();
                int num = 0;
                int count;


                Console.Write("Les nombres premiers entre 1 et " + nbinf + " sont : \n");

                while (num <= nbinf)
                {
                    num++;
                    count = 0;
                    int j = 2;

                    while (j <= num / 2)
                    {
                        j++;
                        if (num % j == 0)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count == 0 && num != 1 && num != 0)
                    {
                        arlist.Add(num);
                    }
                }
                foreach (int item in arlist)
                {
                    Console.WriteLine(item);
                }
            }


            /****************************************************/

            Console.WriteLine("2.Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers(version optimisée).");
            Console.WriteLine();

            Console.Write("Encodez un nombre : ");
            if (int.TryParse(Console.ReadLine(), out int nbinf))
            {
                List<int> listEntier = new List<int>();

                int num = 0;
                int count;

                Console.Write("Les nombres premiers entre 1 et " + nbinf + " sont : \n");

                for (int i = 1; num <= nbinf; num++)
                {
                    count = 0;

                    for (int j = 2; j <= num / 2; j++)
                    {
                        if (num % j == 0)
                        {
                            count++;
                            break;
                        }
                    }

                    if (count == 0 && num != 1 && num != 0)
                    {
                        listEntier.Add(num);
                    }
                }
                foreach (int item in listEntier)
                {
                    Console.WriteLine(item);
                }
            }
            /***************************   Les structures **********************************************/

            //Ecrire deux structures Celsius et Fahrenheit toutes deux ayant une variable température de type “double”.

            /*******************************   Code Louis     *******************************************/
            using System;

struct Celsius
        {
            double v;
            public Celsius(double t)
            { // Constructeur
                this.v = t;
            }
            public Fahrenheit ToFahrenheit()
            {
                return new Fahrenheit((this.v * (9F / 5)) + 32);
            }
            public override string ToString()
            { // On "écrase" la méthode ToString de base
                return String.Format("{0}°C", this.v);
            }
        }

        struct Fahrenheit
        {
            double v;
            public Fahrenheit(double t)
            { // Constructeur
                this.v = t;
            }
            public Celsius ToCelsius()
            {
                return new Celsius((this.v - 32) * (5F / 9));
            }
            public override string ToString()
            { // On "écrase" la méthode ToString de base
                return String.Format("{0}°F", this.v);
            }
        }

        class Prog
        {
            /*
                La méthode Main est le point d'entrée du programme. 
                Lors de l'exécution du programme, les arguments donnés à l'exécutable              seront transférés à la méthode Main sous la forme d'un tableau de string
                d'ou l'argument : string[] args
            */
            static void Main(string[] args)
            {
                if (args[0] == "CTOF")
                {
                    if (double.TryParse(args[1], out double n))
                    {
                        Celsius c = new Celsius(n);
                        Console.WriteLine(String.Format("{0} -> {1}", c, c.ToFahrenheit()));
                    }
                }
                else if (args[0] == "FTOC")
                {
                    if (double.TryParse(args[1], out double n))
                    {
                        Fahrenheit c = new Fahrenheit(n);
                        Console.WriteLine(String.Format("{0} -> {1}", c, c.ToCelsius()));
                    }
                }
            }
        }

        /***************************   Les méthodes **********************************************/

        //1.Dans les structures Celsius et Fahrenheit, écrire la fonction de conversion de l’une vers l’autre.
        //2.Utilisez une fonction pour calculer les nombres premiers dans les 2 boucles de l’exercice des collections.

        /**************************** Les énumérations *********************************************/

        //Décrivez une structure permettant de construire une voiture sur base de valeurs présentes dans des énumérations. 
        //Ensuite, ajoutez lui des méthodes utiles. Une fois construite, faites la rouler et affichez son état dans la console.
    }
}
}

