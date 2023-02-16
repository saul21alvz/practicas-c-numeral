// See https://aka.ms/new-console-template for more information
/*int dato = 300;
Console.Write("En binario es : ");
Console.WriteLine(Convert.ToString(dato,2));
Console.Write("En Hexadecimal es : ");
Console.WriteLine(Convert.ToString(dato, 16));

Console.Write("Dime un dato binario: ");
Console.WriteLine("En decimal es: {0}",
    Convert.ToInt32(Console.ReadLine(),2));
Console.Write("Dime un dato Hexadecimal: ");
Console.WriteLine("En decimal es: {0}",
    Convert.ToInt32(Console.ReadLine(), 16));*/

/*hacer un programa que muestre el siguiente menu
introducir un numero decimal
un numero hexadecimal
un numero binaro
dependiendo de la opcion es el dato que se va a solicitar para realizar las siguientes opciones
1.-si es decimal se elevara al cuadrado y su resultado se mostrara en binari y hexadecimal
2.- Si es binario se sumara el resultado del cudrado del mismo y se mostrara en decimal y hexadecimal 
3.- Si el valor es hedaxecimal se mostrara su tabla de multiplicar , esta tabla seria en Hexadecimal exclusivamente */
int op=0,z;
string a, s, zz, ii, mm;
Console.WriteLine("1.- Introduce un numero en decimal: \n" +
    "2.- Introduce el numero en binario: \n" +
    "3.- Introduce el numero en hexadecmal: ");

while (op == 0 || op > 3 || op < 0)
{
    Console.Write("Opcion ");
   op = Convert.ToInt32(Console.ReadLine());
}
switch (op){
    case 1:
        Console.Write("Escribe el numero en decimal ");
        z = Convert.ToInt32(Console.ReadLine());
        z = z * z;
        Console.WriteLine("El numero en binario "+Convert.ToString(z,2));
        Console.WriteLine("El numero en hexadecimal " + Convert.ToString(z, 16));
        break;
    case 2:
        Console.Write("Escribe el numero en binario ");
        a = Console.ReadLine();
        z = Convert.ToInt32(a,2);
        z += z * z;
        Console.WriteLine("El numero en decimal " + Convert.ToString(z));
        Console.WriteLine("El numero en hexadecimal " + Convert.ToString(z, 16));
        break;
    case 3:
        Console.Write("Escribe el numero en hexaadecimal ");
        a = Console.ReadLine();
        z = Convert.ToInt32(a, 16);
        Console.WriteLine("Tabla del " + z);
        for (int i = 0; i < 11; i++)
        {
            zz = Convert.ToString(z, 16);
            ii = Convert.ToString((z*i),16);
            Console.WriteLine("Tabla del " + zz+ " * " + i+ " = " + ii);
        }
        break;
}
/*
StreamWriter fichero;
string linea;
fichero = File.AppendText("prueba9.txt");
fichero.WriteLine("añadimos texto al fichero, sino existe se crea");
fichero.Close();

StreamReader miLectura = File.OpenText("prueba9.txt");
try
{
    do
    {
        linea = miLectura.ReadLine();
        Console.WriteLine(linea);
    } while (linea != null);

    miLectura.Close();
}
catch (Exception msg) // Si no se puede leer mostramos el error
{
    Console.WriteLine("No se encuentra el archivo " + msg);
}
*/