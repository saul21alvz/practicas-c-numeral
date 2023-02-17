// See https://aka.ms/new-console-template for more information
/* hacer un programa que lea nombre de un producto, cantida y precio 
respectivamente validados y almacenarlos en un archivo, este proceso se realizara hasta que el usuario lo desee
al finalizar se agregara al archivo el total de productos y el total de los precios, considerando la cantidad de productos */


using System;

StreamWriter fichero;
string nombre = "Venta.txt";
string dato = "";
string nom,num,nu,n,bo="s";
int ca=0, pre=0, sum=0, c=0,cp=0;
bool t=false, p=false;

while (bo=="s" || bo=="si") {
    while (t == false) {
        Console.Write("Escribe el nombre del producto ");
        nom = Console.ReadLine();
        Console.Write("Escrive el precio: ");
        num = Console.ReadLine();
        Console.Write("Escribe la cantidad del producto ");
        nu = Console.ReadLine();
        if (int.TryParse(num, out pre)) {
            if (int.TryParse(nu, out ca)) {
                t = true;
            }
            else {
                Console.WriteLine("No son numeros enteros");
                t = false;
                c++;
                cp += ca;
            }
        }
        else {
            Console.WriteLine("No son numeros enteros");
            t = false;
        }
        sum += pre * ca;
    }
    Console.WriteLine("Quieres agregar otro  'si' o 'no'");
    bo = Console.ReadLine();
}

try
{
    fichero = File.AppendText(nombre);//crea el archivo o lo reutiliza
    dato = "Total de Productos "+c.ToString()+" \n" +
        "Total del precio "+sum.ToString()+"\n" +
        "Cantidad de productos "+cp.ToString();
    Console.WriteLine(dato);
    fichero.WriteLine(dato);
    fichero.Close();//cierra el archivo
}
catch (Exception msg) // Si no se puede leer mostramos el error
{
    Console.WriteLine("No se encuentra el archivo " + msg);
}
