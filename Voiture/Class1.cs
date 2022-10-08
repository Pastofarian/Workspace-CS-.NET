using System.Reflection.Metadata.Ecma335;


struct Voiture
{
    public int roues;
    public couleurs couleur;
    public int puissance;
    public int nbrPlaces;
    public int compteur;
    public string message;

    /*
	 * un constructeur n'a pas de retour. Une fonction renvoie toujours qqch même "void"
	 */
    public Voiture(int wheel, couleurs color, int horsePower, int nbrSeat)
    {
        roues = wheel;
        couleur = color;
        puissance = horsePower;
        nbrPlaces = nbrSeat;
        compteur = 0;
        message = "";
    }

    public void Travel(string location)
    {
        if (location == "Bruxelles")
        {
            compteur += 50;
        } 
        else if (location == "Wavre")
        {
            compteur += 20;
        } 
        //else if (location == "" && compteur == 0)
        //{
        //    message = "La voiture est neuve";
        //}
    }

    public override string ToString()
    {
        return "Voiture " +
            "\nroues : " + roues +
            "\ncouleur : " + couleur +
            "\npuissance : " + puissance +
            "\nnbrPlaces : " + nbrPlaces +
            "\ncompteur : " + compteur +
            "\nmessage : " + message;
    }
    public void distance(int temps)
    {
        int metres = puissance * temps;
        compteur += metres;
    }
}
enum couleurs
{
    rouge,
    vert,
    bleu,
    rose,
    violet,
}

//int addNumbers(int a, int b)
//{
//	return a + b;
//}