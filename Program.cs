// See https://aka.ms/new-console-template for more information

Console.WriteLine("LINQ");

IList<string> fruntas = new List<string>() {"Banana", "Maça", "Pera", "Laranja", "Uva"};

// query syntax
var resultado = from f in fruntas
                where f.Contains('r')
                select f;

Console.WriteLine(String.Join(" - ", resultado));

//method syntax
var resultado2 = fruntas.Where(f => f.Contains('r'));
Console.WriteLine(String.Join(" - ", resultado2));

Console.ReadKey();

