// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayList 2");

var lista = new ArrayList()
{
    "Maria", 5 , true, false, 6.0, 5, 0, 89, 0, 45, 0, 0
};


lista.Remove(0);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);


foreach(var list in lista)
{
    Console.WriteLine(list);
}