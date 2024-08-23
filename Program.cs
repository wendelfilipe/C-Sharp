// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enum");

Console.WriteLine(DiasDaSemana.Segunda);
Console.WriteLine(DiasDaSemana.Terca);

int dia1 = (int)DiasDaSemana.Segunda;
int dia2 = (int)DiasDaSemana.Terca;

Console.WriteLine($"\n{DiasDaSemana.Segunda} vale : {dia1}");
Console.WriteLine($"\n{DiasDaSemana.Terca} vale : {dia2}");
Console.ReadKey();

enum DiasDaSemana
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
    
}

