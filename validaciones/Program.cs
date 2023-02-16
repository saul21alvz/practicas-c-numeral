// See https://aka.ms/new-console-template for more information

string num;
int n;
Console.WriteLine("Escribe un numero ");
num = Console.ReadLine();
if (int.TryParse(num, out n))
{
    Console.WriteLine("son puros numeros");
}
else
{
    Console.WriteLine("No son numeros enteros");
}