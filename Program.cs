// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("as e");

// upcasting
Circulo circulo = new Circulo(20, 20);
Forma forma = circulo;

// Downcasting e as

Circulo c = forma as Circulo;

// usando is

if (forma is Circulo)
{
    Console.WriteLine("Converteu forma para circulo");
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possivel");
}

if( c != null)
{       
    c.DesenharForma();
    c.PintarCirculo();
    Console.WriteLine(c == forma);
    Console.WriteLine(c == circulo);    
}
else
{
    Console.WriteLine("Erro ao fazer o casting");
}


Object carroObj = new Carro();

try
{
    var y = (string)carroObj;
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

// usando as

var x = carroObj as string;

if(x != null)
{
    Console.WriteLine("Casting feito com sucesso");
}
else
{
    Console.WriteLine("Não foi possivel converter");
}



class Carro
{}



