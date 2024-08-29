// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayList 2");

ArrayList lista = new()
{
    "Maria", 5 , true
};

int[] lista1 = {1, 2, 3};

lista.AddRange(lista1);

lista.InsertRange(2, lista1);

foreach(var list in lista)
{
    Console.WriteLine(list);
}