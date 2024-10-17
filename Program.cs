
Console.WriteLine("Operadores de conversão");

int[] numeros = new int[]{1, 2, 3, 4, 5, 6};

var result = numeros.AsEnumerable();

var result2 = result.AsQueryable();

foreach (var numero in result)
{
    Console.WriteLine(numero + " ");
}

foreach (var numero in result2)
{
    Console.WriteLine(numero + " ");
}

Console.ReadKey();