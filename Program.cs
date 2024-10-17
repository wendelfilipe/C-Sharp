
Console.WriteLine("Elemento");

List<int> numeros = new  List<int>{1, 2, 3, 4};

var numeroNovo = numeros.Prepend(0).ToList();

Console.WriteLine(String.Join(", ", numeros.Append(5)));

Console.WriteLine(String.Join(", ", numeros.Prepend(0)));

Console.ReadKey();