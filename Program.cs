// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Partil class");

MinhaPartilClass minhaPartilClass = new();

Console.WriteLine("\nIdade para os nascidos em : 02/06/2005\n");
var idade = minhaPartilClass.CalculaIdade( new DateTime(2003, 8 ,7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para os nascidos em : 02/06/2005\n");

var data1 = DateTime.Now;
var data2 = new DateTime(2005, 06, 02);
var diferenca = minhaPartilClass.DifetencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");