using System;
using System.Net;

namespace AsyncDelegate //aussi appelé callback dans d'autres languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var webClient = new WebClient();

            string url = "https://codeavecjonathan.com/res/bateau.jpg"
            webClient.DownloadFile()
        }
    }
}
