// See https://aka.ms/new-console-template for more information
//invesrigar los operadores logicos en c#
/*
float a;

a = 10 / 3.0f;

Console.WriteLine(a);*/
using System.Reflection;

/*int a, b,c;
Console.WriteLine("Escribe un numero");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = a + b;
Console.Write("El resultado ");
Console.Write(c);*/

Console.WriteLine("Escribe cuatro calificaciones ");
int a, b, c, d;
float s;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
c=Convert.ToInt32(Console.ReadLine());
d=Convert.ToInt32(Console.ReadLine());
s=(a+b+c+d)/4.0f;
Console.Write("El promedio es de ");
Console.WriteLine(s);