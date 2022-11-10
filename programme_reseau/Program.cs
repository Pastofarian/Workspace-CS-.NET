using System;
using System.Net;

namespace programme_reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://codeavecjonathan.com/res/exemple.txt";
            string url = "https://codeavecjonathan.com/res/papillon.jpg";

            var webClient = new WebClient();
            Console.WriteLine("Accès au réseau...");
            try
            {
                //string reponse = webClient.DownloadString(url);   //ici la fonction est synchrone mais elle pourrait être async. Ce qui permet de ne pas bloquer le temps du téléchargement
                webClient.DownloadFile(url, "papillon.jpg");
                Console.WriteLine("Téléchargement terminé");

            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("Erreur Reseau : Non trouvé");

                    }
                    else
                    {
                        Console.WriteLine("Erreur Reseau: " + statusCode);
                    }
                }
                else
                {
                    Console.WriteLine("Erreur Reseau : " + ex.Message);
                }
            }

        }
    }
}