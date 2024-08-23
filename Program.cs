// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Construtor estático");

Pessoa p1 = new(19,"Maria");

Console.WriteLine(p1.Name + " - " + p1.Idade);
Console.WriteLine("Idade Minima" + Pessoa.IdadeMinima);

Pessoa p2 = new(20, "Manuel");

Console.WriteLine(p2.Name + " - " + p2.Idade);
Console.WriteLine("Idade Minima" + Pessoa.IdadeMinima);

Console.ReadKey();

