// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Operação com conjutos");

// var idadesDistintas = FonteDeDados.GetIdades().Distinct();

// foreach (var idade in idadesDistintas)
// {
//     Console.WriteLine($"{idade}");
// }

// var nomesDistintos = FonteDeDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase);
// foreach (var nomes in nomesDistintos)
// {
//     Console.WriteLine(nomes);
// }

var alunos = FonteDeDados.GetAlunos().ToList();

var alunosIdadesDistintos =  alunos.DistinctBy(a => a.Idade);
foreach (var aluno in alunosIdadesDistintos)
{
    Console.WriteLine(aluno.Name + " " + aluno.Idade);
}
Console.ReadKey();

