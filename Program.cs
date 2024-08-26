// See https://aka.ms/new-console-template for more information
Console.WriteLine("Try-Catch");

Console.WriteLine("\nInfome o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}   
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero, tente outro número...");
    Console.WriteLine($"erro: {ex.Message}");
    Console.WriteLine($"\n Detalhes : {ex?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Processamento concluido");
}
