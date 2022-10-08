
using System;


internal class Program
{
    static void Main(string[] args)
    {
        var cel = new Celcius();
        var far = new Fahrenheit();

        Console.Write("Donner un température en Celcius à convertir : ");
        cel.Temperature = int.Parse(Console.ReadLine());
        Console.WriteLine(cel.convFahr() + "°F");


        Console.Write("Donner un température en Fahrenheit à convertir : ");
        far.Temperature = int.Parse(Console.ReadLine());
        Console.WriteLine(far.convCel() + "°C");
    }
}





