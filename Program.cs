// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("ArrayList");

ArrayList lista = new();

var list = new ArrayList();

list.Add("Paulo");
list.Add(10);

var list2 = new ArrayList()
{
    "Paulo segunda", 11, 18.00
};

Console.WriteLine(list2[0]);