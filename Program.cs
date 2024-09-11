
Console.WriteLine("Delegate Multicast");

MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2;
delegateMulticast += Metodo3;

delegateMulticast("Ola");

delegateMulticast -= Metodo3;

delegateMulticast("Ola");

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}
static void Metodo2(string mensagem)
{
    Console.WriteLine("Métedo 2: " + mensagem);
}
static void Metodo3(string mensagem)
{
    Console.WriteLine("Métedo 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);