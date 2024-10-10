// See https://aka.ms/new-console-template for more information

using C_;

Console.WriteLine("Operação com conjutos");

List<int> fonte1 = new List<int>(){1, 2, 3, 4, 5, 6};
List<int> fonte2 = new List<int>(){1, 3, 5, 8, 9, 10};

// var result = fonte1.Intersect(fonte2).ToList();

var result = (from num in fonte1
                select num).Intersect(fonte2).ToList();

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.ReadKey();

