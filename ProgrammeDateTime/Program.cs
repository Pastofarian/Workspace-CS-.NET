using System;
using System.Globalization;

namespace ProgrammeDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now; //crée un nouveau DateTime 
            //Console.WriteLine(date);
            //Console.WriteLine(date.Year);

            //Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss"));

            CultureInfo cultureFrançais = CultureInfo.GetCultureInfo("fr-FR");
            Console.WriteLine(date.ToString("dddd dd MMMM yyyy HH:mm:ss", cultureFrançais)); //2ème paramètre (en français) optionel

            DateTime dateDemain = date.AddDays(1); //ajoute un jour

            Console.WriteLine("Demain : " + dateDemain.ToString("dd/MM/yyyy HH:mm:ss"));

            var diff = dateDemain - date;
            Console.WriteLine("Différence heures : " + diff.TotalHours);
        }
    }
}