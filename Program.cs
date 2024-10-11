// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("ordenação crescente\n");

List<string> nomes = new List<string>(){ "Paulo", "Tarcisio", "Amanda", "Pedro", "Manoel", "Carlos"};

var lista = nomes.OrderBy(n => n).ToList();

foreach (var item in lista)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine("\nOdenação descendente\n");
var lista2 = nomes.OrderByDescending(n => n).ToList();

foreach (var item in lista2)
{
    Console.WriteLine(item + " ");
}


// ThenBy

var alunos = FonteDeDados.GetAlunos();

var lista3 = alunos.OrderBy(a => a.Name).ToList();

var lista4 = alunos.Where(a => a.Name.Contains("r")).OrderBy(a => a.Name);

var lista5 = alunos.Where(a => a.Name.Contains("r")).OrderBy(a => a.Name).ThenBy(a => a.Idade);

var lista6 = alunos.Where(a => a.Name.Contains("r")).OrderByDescending(a => a.Name).ThenByDescending(a => a.Idade);

foreach (var item in lista3)
{
    Console.WriteLine($"{item.Name} - {item.Idade}");
}

foreach (var item in lista4)
{
    Console.WriteLine($"{item.Name} - {item.Idade}");
}

foreach (var item in lista5)
{
    Console.WriteLine($"{item.Name} - {item.Idade}");
}

foreach (var item in lista6)
{
    Console.WriteLine($"{item.Name} - {item.Idade}");
}


Console.ReadKey();