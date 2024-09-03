// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sealed");

Cliete cli = new();


class Pessoa
{
    protected string? Name { get; set; }

    protected virtual void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Name}");
    }
}

class Cliete : Pessoa
{
    sealed protected override void ExibeNome()
    {
        Console.WriteLine($"\nNome do Cliente é {Name}");
    }

}