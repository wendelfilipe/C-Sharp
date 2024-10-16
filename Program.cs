
using C_;

Console.WriteLine("Elemento");

string[] paises = {"US", "UK", "India", "Russia", "China", "Brasil", "Peru"};

var resultado = paises.ToList();

foreach (var pais in paises)
{
    Console.WriteLine(pais);
}

// To List
var alunos = FonteDeDados.GetAlunos();

var listaAluno = alunos.Where(a => a.Name.Contains("M")).ToList();
foreach (var aluno in listaAluno)
{
    Console.WriteLine($"\n{aluno.Name}");
}

// To Array

var arrayAluno = alunos.Where(a => a.Name.Contains("M")).ToArray();
foreach (var aluno in arrayAluno)
{
    Console.WriteLine($"\n{aluno.Name}");
}

// Dictionary

var listaDic = alunos.ToDictionary<Aluno, int>(a => a.Id);

foreach (var chave in listaDic.Keys)
{
    Console.WriteLine($"\nChave: {chave}, Valor: {(listaDic[chave] as Aluno).Name}");
}

Console.ReadKey();