// See https://aka.ms/new-console-template for more information
Console.WriteLine("Delegate Action");

var numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raiz = x => Math.Sqrt(x);

Console.WriteLine(raiz(numero));

