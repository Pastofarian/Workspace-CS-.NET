using System;
using System.Net;
using System.Runtime.InteropServices.ObjectiveC;

namespace AsyncDelegate //aussi appelé callback dans d'autres languages
{
    internal class Program
    {
        static bool downloading = false; //variable static parce que'on est dans le Main qui est static
        static void Main(string[] args)
        {
            var webClient = new WebClient();

            Console.Write("Téléchargement ...");
            string url = "https://codeavecjonathan.com/res/bateau.jpg";
            //webClient.DownloadFile(url, "bateau.jpg");

            downloading = true;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted; //tab après += pour créer la fonction
            webClient.DownloadFileAsync(new Uri(url), "bateau.jpg");

            while (true)
            {
                Thread.Sleep(500); //1000 = 1sec
                if (downloading)
                {
                    Console.Write("."); //fonction asynchrone permet d'utiliser ceci pendant le téléchargement
                    break;
                }
            }
            Console.WriteLine("FIN DU PROGRAMME");
        }

        private static void WebClient_DownloadFileCompleted(object? sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Console.WriteLine("téléchargement terminé"); //permet d'attendre la fin du téléchargement du fichier avant de finir le programme (Async n'attend pas)
            downloading = false;
        }

    }
}
