using System;

internal class Program
{
    static void Main(string[] args)
    {

        var car1 = new Voiture(4, couleurs.rouge, 150, 5);
        var car2 = new Voiture(6, couleurs.bleu, 50, 8);

        car1.Travel("Wavre");
        car2.Travel("");

        car2.distance(50);
        Console.WriteLine("Voiture 1 : " + car1);
        Console.WriteLine("Voiture 2 : " + car2);
        //Console.WriteLine(car1.Travel);

    }

}