// See https://aka.ms/new-console-template for more information

//break, continue, goto
//hacer un programa que lea tres numeros,
//si los numeros son iguales se calculara el promedio  de lo contrario se sumaran
//los numeros que son pares o impares entre ellos,
//mostrara el mayor y menor de ellos 

int a, b, c, s, d, f;
Console.Write("Escribe tres numeros ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

//promedio
if((a == b) && (b == c))
{
    Console.WriteLine("El promedio es de " + a);
}
s = a % 2;
d = b % 2;
f = c % 2;
//par o impar
if(s == 0&& d == 0 && f == 0)//todos son pares
{
    Console.WriteLine("Los tres son pares y su suma es {0}",a + b + c);
}else if (s == 0 && d == 0)//a y b son pares
{
    Console.Write("dos numeros son pares y sumados es {0}",a + b);
    Console.WriteLine(" y solo uno es impares {0}",c);
}
else if (f == 0 && d == 0)//b y c son pares
{
    Console.Write("dos numeros son pares y sumados es {0}", c + b);
    Console.WriteLine(" y solo uno es impares {0}", a);
}
else if (s == 0 && f == 0)//a y c son pares
{
    Console.Write("dos numeros son pares y sumados es {0}", a + c);
    Console.WriteLine(" y solo uno es impares {0}", b);
}
else if (s == 0)//a es par
{
    Console.WriteLine("solo uno es par y es  {0} y la suma de dos impares {1}",a, b + c);
}
else if (d == 0)//b es par
{
    Console.WriteLine("solo uno es par y es  {0} y la suma de dos impares {1}", b, a + c);
}
else if (f == 0)//c es par
{
    Console.WriteLine("solo uno es par y es  {0} y la suma de dos impares {1}", c, a + b);
}
else//todos son impares

{
    Console.WriteLine("todos los numeros son impares y su suma es {0}", a + b + c );
}

//mayor
if ((a > b) && (a>c))
{
    Console.WriteLine("El mayor es " + a);
}
else if ((b > a) && (b > c))
{
    Console.WriteLine("El mayor es " + b);
}
else
{
    Console.WriteLine("El mayor es " + c);
}

//menor
if ((a < b) && (a < c))
{
    Console.WriteLine("El menor es " + a);
}
else if ((b < a) && (b < c))
{
    Console.WriteLine("El menor es " + b);
}
else
{
    Console.WriteLine("El menor es " + c);
}