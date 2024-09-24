
Console.WriteLine("File info");

var caminhoOrigem = @"C:/Users/wendelfilipe/Documents/estudos/poesia.txt";
var caminhoDestino = @"C:\Users\wendelfilipe\Documents\estudos\txt\poesia.txt";
var caminhoCopia = @"C:\Users\wendelfilipe\Documents\estudos\poesia_copia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: " + arquivoOrigem.Name);

Console.WriteLine("\nCaminho completo do arquivo " + arquivoOrigem.FullName);

Console.WriteLine("\nO arquivo é somente leitura " + arquivoOrigem.IsReadOnly);

var diretorioPai = arquivoOrigem.Directory;

Console.WriteLine("\nNome do diretorio " + diretorioPai.Name);

Console.WriteLine("\nTamanho do arquvo " + arquivoOrigem.Length);

Console.WriteLine("\nUltima gravação " + arquivoOrigem.LastWriteTime);

if(arquivoOrigem.Exists)
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo existe. Copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);
}
else
{
    Console.WriteLine($"\nO {caminhoOrigem} arquivo não existe.");
}

Console.WriteLine($"\nMovendo {caminhoOrigem} para a {caminhoDestino}.");
arquivoOrigem.MoveTo(caminhoDestino);


Console.ReadKey();

