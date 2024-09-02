// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Indexadores");

var time = new Time();

time[1] = "Palmeiras";
time[2] = "Santos";
time[3] = "São paulo";
time[-1] = "Flamengo";
time[100] = "Galo";

string valor1 = time[1];
string valor2 = time[2];
string valor3 = time[3];
string valor4 = time[-1];
string valor5 = time[100];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);




