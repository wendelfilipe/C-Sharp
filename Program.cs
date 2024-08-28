// See https://aka.ms/new-console-template for more information
Console.WriteLine("Multidimentional Arrays");

int[,] n = {
    {1, 4, 2}, 
    {3, 6, 8},
    {3, 6, 8}
};

for (int i = 0; i < n.GetLength(0); i++ )
{
    for(int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i,j]} ");
    }
    Console.WriteLine();
}
