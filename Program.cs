// See https://aka.ms/new-console-template for more information
Console.WriteLine("Struct");

Cliente cliente = new();

cliente.Name = "Maria";
cliente.Idade = 19;

Console.WriteLine($"{cliente.Name} {cliente.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string Name { get; set; }
    public int Idade { get; set; }

    public Cliente(string name, int idade)
    {
        Name = name;
        Idade = idade;
    }
}
