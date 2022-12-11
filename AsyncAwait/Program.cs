using System;
using System.Runtime.CompilerServices;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url1 = "https://codeavecjonathan.com/res/dummy.txt";
            string url2 = "https://codeavecjonathan.com/res/pizzas1.json"; //fichier bcp plus petit que dummy.txt


            Console.Write("Téléchargement ...");
            var displayTask = DisplayProgress();
            var downloadTask1 = DownloadData(url1);
            var downloadTask2 = DownloadData(url2);


            await downloadTask1;
            await downloadTask2;
            Task.WhenAll(downloadTask1, downloadTask2);


            Console.WriteLine("FIN DU PROGRAMME");
        }

        static async Task DownloadData(string url) //une fonction async retourne tjs un type Task. Task tout court = void / Task<string> retourne un string
        {

            var httpClient = new HttpClient();

            var resultat = await httpClient.GetStringAsync(url);

            Console.WriteLine("Ok " + url);

            //Console.WriteLine(resultat);
        }

        static async Task DisplayProgress()
        {
            while (true)
            {
                await Task.Delay(500);
                Console.Write(".");
            }
        }
    }
}

