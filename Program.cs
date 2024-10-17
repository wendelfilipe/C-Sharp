
using C_;

Console.WriteLine("Elemento");

var pares = Enumerable.Range(10, 50).Where(x => x % 2 == 0);

foreach(int i in pares)
{
    Console.Write(i + " ");
}

var textos = Enumerable.Repeat("Macoratti.net - LINQ", 10);

foreach (String txt in textos)
{
    Console.WriteLine(txt);
}


var vazio = Enumerable.Empty<string>();

foreach (var num in vazio)
{
    Console.Write($"\n{num}");
}


Console.ReadKey();