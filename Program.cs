string[] cursos = {"c#", "Python", "Java"};
Queue<string> fila1 = new Queue<string>(cursos);

Console.WriteLine("No. de Elementos na fila 1 : " + fila1.Count());

ExibirFila(fila1);
fila1.Enqueue(".NET MAUI");
ExibirFila(fila1);

Console.WriteLine("\n- Obtem o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n- Metodo Dequeue - remove item do inicio da fila");
fila1.Dequeue();
ExibirFila(fila1);

Console.WriteLine("\n- Metodo Clear");
fila1.Clear();
ExibirFila(fila1);


static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
        Console.WriteLine(item);
}

