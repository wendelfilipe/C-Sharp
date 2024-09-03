// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Upcasting e Downcasting");

// upcasting
Circulo circulo = new Circulo(20, 20);
Forma forma = circulo;

forma.DesenharForma();

// Downcasting

Circulo c = (Circulo)forma;

c.DesenharForma();
c.PintarCirculo();

Console.WriteLine(c == forma);
Console.WriteLine(c == circulo);





