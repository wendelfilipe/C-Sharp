// See https://aka.ms/new-console-template for more information
Console.WriteLine("File");

string caminhoDestino = @"/home/wendel/Documentos/Estudos/arquivo1.txt";
string caminhoOrigem = @"arquivo1.txt";

if(!File.Exists(caminhoDestino))
{

    try
    {

        // Criar arquivo

        // File.Create(caminhoOrigem);

        File.WriteAllText(caminhoOrigem, "Fernando Pessoa\r\n");

        string novoTexto = "O poeta é um fingidor\r\n" + "Finge tão completamente\r\n" + "Que chega a fingir que é dor\r\n";

        File.AppendAllText(caminhoOrigem, novoTexto);

        string conteudo = File.ReadAllText(caminhoOrigem);
        Console.WriteLine(conteudo);

        var caminhoCopia = @"arquivo2.txt";

        Console.WriteLine( $"Copiando de {caminhoOrigem} para {caminhoCopia}");

        File.Copy(caminhoOrigem, caminhoCopia);


        Console.WriteLine( $"Movendo de {caminhoOrigem} para {caminhoDestino}");
        File.Move(caminhoOrigem, caminhoDestino);

        Console.WriteLine( $"Deletando {caminhoOrigem}, {caminhoCopia} e {caminhoCopia}");
        File.Delete(caminhoOrigem);
        // File.Delete(caminhoDestino);
        File.Delete(caminhoCopia);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Concluido");

