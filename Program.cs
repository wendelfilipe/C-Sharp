// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classe random ");

Random random = new Random();

// Console.WriteLine(random.Next());
// Console.WriteLine(random.Next(20));
// Console.WriteLine(random.Next(10, 20));
// Console.WriteLine(random.NextDouble());


int[] numerosSorteados = new int[7];

for (int i = 0; i < 7; i++)
{
    int numerosAleatorios;

    do
    {
        numerosAleatorios = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numerosAleatorios));

    numerosSorteados[i] = numerosAleatorios; 
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));