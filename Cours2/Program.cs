using System;
using System.Reflection;
using System.Text;

namespace Cours2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /***********************   Les Conversions   *********************************************************/
            int a = 2;
            string b = a.ToString(); //convertir en string

            Console.WriteLine(b);

            /*********************************/

            int a = Convert.ToBoolean; // autre façon de convertir. Voir documentation intégré.
            Console.WriteLine(a);

            /********************************/

            /*int nbrDeFichiertotal = 208;
            int nbrDeFichierCopies = 52;

            float pourcent = ((float)100)nbrDeFichiertotal / nbrDeFichierCopies);
            Ne fonctionne pas */


            Console.WriteLine(208 / 53.0);

            int a = 208;
            int b = 53;
            Console.WriteLine((double)a / b);

            /******************************/

            //Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.Parse() »
            var test1 = int.Parse(Console.ReadLine());
            var test2 = int.Parse(Console.ReadLine());

            Console.WriteLine(test1 + test2);

            //Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.TryParse() »


            int a;
            int b;
            var test3 = int.TryParse(Console.ReadLine(), out a);
            var test4 = int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine(a + b);


            int a = Convert.ToInt32("2");
            int b = int.Parse("3");

            Console.WriteLine("Entrez un nombre");

            int c;
            var response = int.TryParse(Console.ReadLine(), out c);
            if (response == false)
                Console.WriteLine("Ce n'est pas un nombre");
            else
                Console.WriteLine(c * a);

            /*****************    A la maison   ************************/

            Console.WriteLine("Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.Parse()»");
            Console.WriteLine("En utilisant la méthode « Console.ReadLine()");

            Console.Write("Entrez un premier nombre : ");
            int num1 = int.Parse(Console.ReadLine());      // génere une erreur si autre que nombre

            Console.Write("Entrez un deuxieme nombre : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");

            int result1 = num1 + num2;
            Console.WriteLine($"Résultat de l'adition de  {num1} + {num2} = {result1}");


            Console.WriteLine("Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, la conversion devra utiliser la méthode « int.TryParse()»");

            Console.Write("Entrez un premier nombre : ");
            bool input1 = int.TryParse(Console.ReadLine(), out int num3);      // ne génere pas d'erreur si autre que nombre

            Console.Write("Entrez un deuxieme nombre : ");
            bool input2 = int.TryParse(Console.ReadLine(), out int num4);

            Console.WriteLine("---------------------");

            int result2 = num3 + num4;
            Console.WriteLine($"Résultat de l'adition de  {num3} + {num4} = {result2}");

            /* pour tester un nombre*/
            Console.Write("Entrez un nombre : ");
            bool input3 = int.TryParse(Console.ReadLine(), out int num5);
            if (input3)
            {
                Console.WriteLine($"here is the number '{num5}'.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{num5} failed.");
            }

            /**********************      Les instructions conditionnelles     *****************************/

            Console.WriteLine("Demander à l’utilisateur d’encoder 1 nombre(int), si le modulo de 2 est 0, afficher “le nombre est paire” sinon “le nombre est impaire”.");

            var test1 = int.Parse(Console.ReadLine());

            if (test1 % 2 == 0)
            {
                Console.WriteLine("pair");
            }
            else
            {
                Console.WriteLine("impair");
            }

            /****************************** A la maison *******************************/

            Console.WriteLine("Demander à l’utilisateur d’encoder 1 nombre(int), si le modulo de 2 est 0, afficher “le nombre est paire” sinon “le nombre est impaire”.");
            Console.WriteLine();

            Console.WriteLine("Encodez un nombre");

            bool input7 = int.TryParse(Console.ReadLine(), out int isPair);

            if (input7)
            {
                if (isPair % 2 == 0)
                {
                    Console.WriteLine($"{isPair} est un nombe pair");
                }
                else
                {
                    Console.WriteLine($"{isPair} est un nombe impair");
                }
            }
            else
            {
                Console.WriteLine($"NAN");
            }
            /*****************************/

            //Calcule de la division entière, du modulo et de la division de deux entiers.
            //Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo: 1, Division: 2,5.

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("division entière " + num1 / num2 + " modulo " + num1 % num2 + " division " + (float)num1 / (float)num2);

            /****************************** A la maison *******************************/

            Console.WriteLine("Calcule de la division entière, du modulo et de la division de deux entiers.");
            Console.WriteLine("Résultat attendu pour 5 et 2 🡪 Division entière : 2, Modulo: 1, Division: 2,5.");
            Console.WriteLine();

            Console.WriteLine("Encodez le dividende");
            bool input4 = int.TryParse(Console.ReadLine(), out int div1);
            Console.WriteLine("Encodez le diviseur");
            bool input5 = int.TryParse(Console.ReadLine(), out int div2);


            if (input2)
            {
                Console.WriteLine($"{div1} / {div2} = {div1 / div2}");
                Console.WriteLine($"{div1} % {div2} = {div1 % div2}");
                Console.WriteLine($"{div1} / {div2} = {(float)div1 / (float)div2}");

            }
            else
            {
                Console.WriteLine($"NAN");
            }

            /*************************    Les opérateurs        ********************************/

            Console.WriteLine("Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.");
            //Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
            //(utilisez la méthode « Substring » de la classe « string »).

            //uint exemple = 3216549871 % 97;  //Check-digit = 92
            //Console.WriteLine(exemple);

            Console.WriteLine("Encodez le compte banquaire à 12 chiffres");
            var bankAccount = Console.ReadLine();

            string firstNum = bankAccount.Substring(0, 10);
            int lastNum = int.Parse(bankAccount.Substring(10));
            uint modulo = uint.Parse(firstNum) % 97;

            if (lastNum == modulo)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("KO");
            }

            /***************************      Comment éviter le var comme variable ?    ************/


            /******************************/

            Console.WriteLine("Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) en IBAN(BExx-xxxx-xxxx-xxxx). Trouvez la démarche via un moteur de recherche.");


            var bankAccount2 = "123456789002";

            var firstNum2 = int.Parse(bankAccount2.Substring(0, 10));
            var lastnum2 = int.Parse(bankAccount2.Substring(10));
            var checkDigit = 98 - (firstNum2 % 97);
            Console.WriteLine($"IBAN = BE {checkDigit} - {bankAccount2.Substring(0, 4)} - {bankAccount2.Substring(4, 4)} - {bankAccount2.Substring(8, 4)}");

            /****************************/



        }

    }
}






