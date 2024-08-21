// See https://aka.ms/new-console-template for more information
Console.WriteLine("Métodos estáticos");

Calculadora.Somar(10, 10);

public static class Calculadora

{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
}


