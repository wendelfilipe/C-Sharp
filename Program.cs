// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("List<T>");

var lista = new List<string>()
{
    "Maria", "Ana", "Bruna", "Carol", "Thais"
};

var lista2 = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7
};

var addNome = Console.ReadLine();


lista.Add(addNome);

lista.Sort();

lista2.Remove(6);
lista2.RemoveAt(4);
lista2.RemoveRange(0, 3);

foreach(var list in lista)
{
    Console.WriteLine(list);
}

foreach(var list in lista2)
{
    Console.WriteLine(list);
}