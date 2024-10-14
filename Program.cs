// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Aggregate");

int[] numeros = {3, 5, 7, 9};

int result = numeros.Aggregate((n1, n2) => n1 * n2);



var alunos = FonteDeDados.GetAlunos();

string listaAlunos = alunos.Aggregate<Aluno, string>("Nomes :", (semente, aluno) => semente += aluno.Name + ",");

int indice = listaAlunos.LastIndexOf(",");
listaAlunos = listaAlunos.Remove(indice);

string listaAlunos2 = alunos.Aggregate<Aluno, string, string>(
    "Nomes :", 
    (sement, aluno) => sement += aluno.Name + ",", 
    result => result.Substring(0, result.Length - 1));

Console.WriteLine(listaAlunos2);

Console.ReadKey();