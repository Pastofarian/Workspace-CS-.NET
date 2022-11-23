// C#10 - LAMBDAS

using System.Runtime.CompilerServices;

int Filtre1(int v) //si la valeur est en dessous de 0 retourne 0
{
    if (v < 0)
        return 0;

    return v;
}
int Operation(int a, int b, Func<int, int> f, [CallerArgumentExpression("f")] string? nom_param = null)
{
    a = f(a);
    b = f(b);
    //CallerArgumentExpression surtout utiliser pour du débug
    Console.WriteLine("Fonction de filtrage : " + nom_param);
    return a + b;
}

//Func<int, int> filtre2 = (int v) => v > 10 ? 10 : v; // C#9
var filtre2 = (int v) => v > 10 ? 10 : v; // C#10


Console.WriteLine(Operation(5, 20, filtre2));