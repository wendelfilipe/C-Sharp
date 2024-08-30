// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayList 4");

var lista = new ArrayList()
{
    "Maria", 5 , true, false, 6.0, 5, 0, 89, 0, 45, 0, 0
};

var lista2 = new ArrayList()
{
    "Maria", "Ana", "Bruna", "Carol", "Thais"
};

lista2.Sort();

var res = lista2.Contains("Maria");

lista2.Clear();

lista.Remove(0);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);


foreach(var list in lista2)
{
    Console.WriteLine(list);
}

Console.WriteLine(res);