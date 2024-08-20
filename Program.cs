// See https://aka.ms/new-console-template for more information
Console.WriteLine("optional paramenters");

Email email = new();
Console.WriteLine("informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("informe o titulo");
var titulo = Console.ReadLine();

Console.WriteLine("informe o assunto");
var assunto = Console.ReadLine();

email.Enviar(destino);

email.Enviar(destino, titulo);

email.Enviar(destino, titulo, assunto);

email.Enviar(destino, assunto: assunto);

public class Email 
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto: {assunto}");
    }
}