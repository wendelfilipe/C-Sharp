// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Join");

using (var context = new AppDbContext())
{
    var rightJoin = ( from s in context.Setores
                        join f in context.Funcionarios
                        on s.Id equals f.SetorId
                        into SetorFunciGrupo
                        from funcionario in SetorFunciGrupo.DefaultIfEmpty()
                        select new
                        {
                            NomeFuncionario = funcionario.Name,
                            CargoFuncionario = funcionario.CargoFuncionario,
                            NomeSetor = s.Name
                        }).ToList();

    Console.WriteLine("Funcionaio\t\tCargo\t\t\tSetor");

    foreach (var funcionario in rightJoin)
    {
        Console.WriteLine($"{funcionario.NomeFuncionario}" + 
                          $"\t\t {funcionario.CargoFuncionario}" +
                          $"\t\t {funcionario.NomeSetor}");
    }
}

Console.ReadKey();