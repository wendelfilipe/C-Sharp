// See https://aka.ms/new-console-template for more information
Console.WriteLine("Generics");

var teste2 = new Teste2<int, int>();

int p1 = 10;
int p2 = 10;


teste2.Comparar(p1, p2);
class Teste
{
    public void Comparar<T>(T p1, T p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()}" );
        var result = p1.Equals(p2);
        Console.WriteLine($" {p1} e {p2} são iguais ? {result}\n");
    }
}

class Teste2<T1, T2> where T1 : struct where T2 : struct
{
    public void Comparar(T1 p1, T2 p2)
    {
        Console.WriteLine($"Os tipos : {p1.GetType()} e {p2.GetType()}" );
        var result = p1.Equals(p2);
        Console.WriteLine($" {p1} e {p2} são iguais ? {result}\n");
    }
}
