// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe dos numeros ");
int a, b;
a=Convert.ToInt32(Console.ReadLine());
b=Convert.ToInt32(Console.ReadLine());
float m, d;
m = (float)a * (float)b;
d = (float)a / (float)b;
Console.Write("La multiplicacion es de los numeros es ");
Console.WriteLine(m);
Console.Write("La divicion es de los numeros es ");
Console.WriteLine(d);
m = (float)Math.Pow(a,b);
Console.Write("La potencia del primer con el segundo es de ");
Console.WriteLine(m);
m = (float)Math.Sqrt(a);
d= (float)Math.Sqrt(b);
Console.Write("La raiz del primer numero es ");
Console.WriteLine(m);
Console.Write("La raiz del segundo numero es ");
Console.WriteLine(d);


