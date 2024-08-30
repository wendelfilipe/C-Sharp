// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("List<T>");

var lista = new List<string>()
{
    "Maria", "Ana", "Bruna", "Carol", "Thais", "Wendel"
};

var name = Console.ReadLine();

var nomes = lista.Find(l => l.Contains('n'));
Console.WriteLine (nomes);

var names2 = lista.FindLast(l => l.Contains('a'));
Console.WriteLine(names2);

var names3 = lista.FindIndex(l => l.Contains('a'));
Console.WriteLine($"indice = {names3} item = {lista[names3]}");

var names4 = lista.FindLastIndex(l => l.Contains('a'));
Console.WriteLine($"indice = {names4} item = {lista[names4]}");

var names5 = lista.FindAll(l => l.Contains(name.ToLower()));

foreach(var names in names5)
{
    Console.WriteLine(names);
}



bool Procura(string item)
{
    return item.Contains('n');
}
