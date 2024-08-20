// See https://aka.ms/new-console-template for more information
Console.WriteLine("Argumentos nomeados");

Email email = new();

email.Enviar("teste@teste", "Urgente", "Reunião");

public class Email 
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \nAssunto: {assunto}");
    }
}

