// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("GroupBy");
var alunos =  FonteDeDados.GetAlunos();
var grupos = alunos.GroupBy(a => a.Sexo);

var gropo2 = from a in alunos
            group a by a.Sexo;


foreach (var grupo in grupos)
{
    Console.WriteLine($"\nSexo : {grupo.Key} alunos: {grupo.Count()}");

    foreach (var aluno in grupo)
    {
        Console.WriteLine($"\t{aluno.Name} {aluno.Nota}");
    }
}

Console.ReadKey();