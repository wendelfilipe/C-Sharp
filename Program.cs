// See https://aka.ms/new-console-template for more information
Console.WriteLine("Multidimentional Arrays");

int[,] ints = new int[3,3];

ints[0,0] = 1;
ints[0,1] = 2;
ints[2,2] = 3;

Console.WriteLine(ints[0,0]);
Console.WriteLine(ints[0,1]);
Console.WriteLine(ints[2,2]);