// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geneics dictionary");

Dictionary<int, int> dict1 = new Dictionary<int, int>();

var dic2 = new Dictionary<int, int>();

dic2.Add(2, 100);
dic2.Add(4, 400);

var dic3 = new Dictionary<int, int>()
{
    {1 ,100},
    {2, 200}
};

try 
{
    dic3.Add(2, 200);
}
catch(Exception e)
{
    Console.Write(e.Message);
    Console.Write(e.ToString());
}

Console.WriteLine("\nUsando o metodo");
var resultado = dic3.TryAdd(2, 200);
Console.WriteLine("Elemento foi incluido ? " + resultado);


if(!dic3.ContainsKey(7));
{
    dic3.Add(7, 700);
}

Console.WriteLine(dic3[7]);

Console.WriteLine("\nUsando o ContainsValue");
if(dic3.ContainsValue(700))
{
    Console.WriteLine("O valor existe");
}

Console.WriteLine("\nAlterando o valor");
if(dic3.ContainsKey(7))
{
    dic3[7] = 777;
}

Console.WriteLine("\nValor alterado " + dic3[7]);

Console.WriteLine("\nTentando obter elemento com chave(5) inexistente");

try
{
    Console.WriteLine(dic3[5]);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ToString());
}

Console.WriteLine("\nUsando o TryGetValue()");

if(dic3.TryGetValue(7, out int valor))
{
    Console.WriteLine("\nValor para a chave = " + valor);
}
else 
{
    Console.WriteLine("\nChave nao encotrada");
}

dic3.Add(6,666);
dic3.Add(4,444);

foreach( var dic in dic3)
{
    Console.WriteLine($"{dic.Key} { dic.Value}");
}

Console.WriteLine("\nOrdenando os elementos do dicionário(SortedDictionary/LINQ)");

var dic3Ordenado = new SortedDictionary<int, int>(dic3);

foreach( var dic in dic3Ordenado)
{
    Console.WriteLine($"{dic.Key} { dic.Value}");
}

Console.WriteLine("\nUsando LINQ");

var dic3OrdenadoLinq = dic3.OrderBy(x => x.Key);

foreach( var dic in dic3OrdenadoLinq)
{
    Console.WriteLine($"{dic.Key} { dic.Value}");
}