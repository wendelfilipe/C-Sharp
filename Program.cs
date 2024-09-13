// See https://aka.ms/new-console-template for more information
Console.WriteLine("LINQ");

List<string> nomes = new List<string>()
{
    "Ana", "Maria", "Paulo", "Hugo"
};

var resultado = from m in nomes
                where m.Contains("o")
                select m;

ExibirResultado(resultado);

var resultado1 = nomes.Where(nome => nome.Contains("a"));

ExibirResultado(resultado1);

static void ExibirResultado(IEnumerable<string> resultado)
{
    foreach(var item in resultado)
        Console.WriteLine(item);
}