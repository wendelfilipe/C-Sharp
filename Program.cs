// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Classe Abstrata");


Console.WriteLine("\nInforme o valor do lado do quadrado");
var lado = Convert.ToInt32(Console.ReadLine());


Quadrada quadrada = new Quadrada(lado);

Console.WriteLine(quadrada.Descricao());

Console.WriteLine("\nInfome a cor da figura");
quadrada.Cor = Console.ReadLine();


quadrada.CalcularArea();
quadrada.CalcularPerimentro();

Console.WriteLine($"\nArea do quadrado : {quadrada.Area} m2");
Console.WriteLine($"\nPerimentro do quadrado : {quadrada.Perimetro} m");

Console.WriteLine($"\nCor do quadrado : {quadrada.Cor}");



