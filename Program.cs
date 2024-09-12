// See https://aka.ms/new-console-template for more information
Console.WriteLine("Delegate Action");

var numero = Convert.ToInt32(Console.ReadLine());


Action<int> dobra = x => Console.WriteLine(x * 2);

dobra(numero);