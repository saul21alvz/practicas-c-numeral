// See https://aka.ms/new-console-template for more information
//for

/*for (int x = 0; x <=10; x++)
{
    Console.WriteLine(x);
}
for (int x = 10; x >=0; x--)
{
    Console.WriteLine(x);
}*/

/*int x = 0;
Console.WriteLine(x++);
Console.WriteLine(++x);

string[] a = { "Hola", "pa" };
foreach (string i in a)
{
    Console.WriteLine(i);
}*/

/*int x = 0;
while (true)
{
    x++;
    if (x > 10)
    {
        break;
    }
    else
    {
        Console.WriteLine(x);
    }
}*/

int a;
while (true)
{
    Console.Write("Escribe un numero ");
    a=Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
       if (a%2==0 || a==1)
        {
            break;
        }
        else
        {
            Console.WriteLine("El numero tiene que ser par {0}", a);
        }
    }
    else
    {
        Console.WriteLine("El numero tiene que ser mayor a 0 {0}", a);
    }
}

Console.WriteLine("Los numeros entre el 0 y el {0}", a);
for (int i = 1;i < a; i++)
{
    Console.WriteLine(i);
}



//while

//do while
