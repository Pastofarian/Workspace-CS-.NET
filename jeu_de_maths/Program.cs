using System;

namespace jeu_de_maths
{
    class Program
    {

        enum e_Operator
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3
        }
        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;
            while (true)
            {
                Random rand = new Random();

                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operator o = (e_Operator)rand.Next(1, 4);
                int resultatAttendu;

                switch (o)
                {
                    case e_Operator.ADDITION:
                        Console.Write(a + " + " + b + " = ");
                        resultatAttendu = a + b;
                        break;
                    case e_Operator.MULTIPLICATION:
                        Console.Write(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;
                    case e_Operator.SOUSTRACTION:
                        Console.Write(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.WriteLine("ERREUR : opérateur inconnu");
                        return false;
                }

                //if(o == e_Operator.ADDITION)
                //{
                //    Console.Write(a + " + " + b + " = ");
                //    resultatAttendu = a + b;
                //} 
                //else if(o == e_Operator.MULTIPLICATION)
                //{
                //    Console.Write(a + " x " + b + " = ");
                //    resultatAttendu = a * b;
                //}
                //else if(o == e_Operator.SOUSTRACTION)
                //{
                //    Console.Write(a + " - " + b + " = ");
                //    resultatAttendu = a - b;

                //} else
                //{
                //    Console.WriteLine("ERREUR : opérateur inconnu");
                //    return false;
                //}


                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if(reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
        }

        static void Main(string[] args)
        {
            const int NB_QUESTION = 5;
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int points = 0;

            for(int i = 0; i < NB_QUESTION; i++)
            {
                Console.WriteLine("Question n° " + (i+1) + " / " + NB_QUESTION);
                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Vous avez trouvez");
                    points++;
                }
                else
                {
                    Console.WriteLine("manqué");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points : " + points + " / " + NB_QUESTION);
            if(points == 0)
            {
                Console.WriteLine("Réviser vos maths");
            } else if(points == NB_QUESTION)
            {
                Console.WriteLine("Excellent ! ");
            } else if(points > (NB_QUESTION / 2))
            {
                Console.WriteLine("Pas mal");
            }
            else
            {
                Console.WriteLine("Peut mieux faire");
            }
        }
    }
}