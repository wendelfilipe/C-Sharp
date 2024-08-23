// See https://aka.ms/new-console-template for more information
Console.WriteLine("campo estatico");

A a1 = new A();
a1.x = 10;

A a2 = new A();
a2.x = 20;

A.y = 30;

Console.WriteLine($"a1.x = {a1.x} a2.x = {a2.x} A.y = {A.y}");

public class A 
{
    public int x;
    public static int y;
}