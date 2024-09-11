// See https://aka.ms/new-console-template for more information
using C_;

Console.WriteLine("Delegates");

// DelegateCalc calc = new DelegateCalc(Calculadora.Somar);
// var result = calc.Invoke(20, 30);
// Console.WriteLine(result);


DelegateCalc calc2 = Calculadora.Somar;
var result2 = calc2(20, 30);
Console.WriteLine(result2);

DelegateCalc calc3 = Calculadora.Multiplicar;
var result3 = calc3(20, 30);
Console.WriteLine(result3);


// DelegateCalc calc3 = (float x, float y) => Calculadora.Somar(x, y);
// var result3 = calc3(20, 30);
// Console.WriteLine(result3);

public delegate float DelegateCalc(float x , float y);
