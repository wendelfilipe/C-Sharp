
Console.WriteLine("Delegate Predicate");

Console.WriteLine("\nInforme Um numero inteiro");
int numero = Convert.ToInt32(Console.ReadLine());


Predicate<int> predicate = x => x % 2 == 0;

if(predicate(numero))
{
    Console.WriteLine($"O numero { numero } é PAR");
}
else
{
    Console.WriteLine($"O numero { numero } é Impar ");
}