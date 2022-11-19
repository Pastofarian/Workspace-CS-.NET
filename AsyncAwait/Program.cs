using System;
using System.Runtime.CompilerServices;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string url1 = "https://codeavecjonathan.com/res/dummy.txt";
            string url2 = "https://codeavecjonathan.com/res/dummy.txt";


            Console.Write("Téléchargement ...");
            var displayTask = DisplayProgress();
            var downloadTask = DownloadData();

            await downloadTask;

            Console.WriteLine("FIN DU PROGRAMME");
        }

        static async Task DownloadData() //une fonction async retourne tjs un type Task. Task tout court = void / Task<string> retourne un string
        {

            var httpClient = new HttpClient();

            var resultat = await httpClient.GetStringAsync(url);

            Console.WriteLine("Ok");

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
