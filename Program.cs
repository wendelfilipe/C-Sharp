// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Peradores de projeção");

// IEnumerable<Aluno> alunos = FonteDeDados.GetAlunos().ToList();

// Console.WriteLine("Alunos Notas\n");

// foreach (var aluno in alunos)
// {
//     Console.WriteLine($"{aluno.Name} : {aluno.Nota}");
// }


// IEnumerable<string> names = FonteDeDados.GetAlunos().Select(n => n.Name);

// Console.WriteLine("Alunos Notas\n");

// foreach (var name in names)
// {
//     Console.WriteLine($"{name}");
// }

List<Aluno> lista = FonteDeDados.GetAlunos().Select(a => new Aluno(){
    Name = a.Name,
    Idade = a.Idade,
}).ToList();

foreach (var aluno in lista)
{
    Console.WriteLine($"{aluno.Name} - {aluno.Idade}");
}


Console.ReadKey();

