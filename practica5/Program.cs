// See https://aka.ms/new-console-template for more information
/* hacer un progama que lea nombre cantidad y precio
 * de 5 productos el programa mostrara al 
 * finalisar el % de iva y el total a pagar */

String n1, n2, n3, n4, n5;
int c1, c2, c3, c4, c5;
double p1, p2, p3, p4, p5,mp;

Console.Write("Escribe el nombre del producto ");
n1 = Console.ReadLine();
Console.Write("Escribe la cantidad del producto ");
c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el precio del producto ");
p1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escribe el nombre del producto ");
n2 = Console.ReadLine();
Console.Write("Escribe la cantidad del producto ");
c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el precio del producto ");
p2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escribe el nombre del producto ");
n3 = Console.ReadLine();
Console.Write("Escribe la cantidad del producto ");
c3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el precio del producto ");
p3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escribe el nombre del producto ");
n4 = Console.ReadLine();
Console.Write("Escribe la cantidad del producto ");
c4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el precio del producto ");
p4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Escribe el nombre del producto ");
n5 = Console.ReadLine();
Console.Write("Escribe la cantidad del producto ");
c5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el precio del producto ");
p5 = Convert.ToDouble(Console.ReadLine());

mp = c1 * p1 + c2 * p2 + c3 * p3 + c4 * p4 + c5 * p5;

Console.WriteLine("Total a pagar sin iva {0} iva a pagar {1} total a pagar con iva {2}", mp, mp * .16, mp * 1.16);