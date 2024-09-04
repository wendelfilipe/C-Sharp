// See https://aka.ms/new-console-template for more information
using C_;

// Polimorfismo por Henraça
Console.WriteLine("Polimorfismo");

var figuras = new List<Figura>
{
    new Circulo(),
    new Triangulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}


// Polimorfismo Static por sobrecarga de metodo

var calc = new Calcular();

Console.WriteLine(calc.Somar(1,2));
Console.WriteLine(calc.Somar(1,2,3));


class Calcular
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {
        return num1 + num2 + num2;
    }
}