// See https://aka.ms/new-console-template for more information

StreamWriter fichero;
string nombre = "tabla.txt";
string dato = "";
int a, r=0;
fichero = File.AppendText(nombre);//crea el archivo o lo reutiliza
fichero.Close();

try
{
    /*StreamReader milectura = File.OpenText(nombre);//abrimos el archivo
    Console.WriteLine(milectura);*/
    fichero = File.AppendText(nombre);//crea el archivo o lo reutiliza
    Console.Write("Escribe un numero ");
    a = Convert.ToInt32(Console.ReadLine());
    for (int x = 1; x < 10; x++)
    {
        r = a * x;
        dato = a.ToString() + " * "+x.ToString()+ " = " + r.ToString();
        Console.WriteLine(dato);
        fichero.WriteLine(dato);
    }
    fichero.Close();//cierra el archivo
}
catch (Exception msg) // Si no se puede leer mostramos el error
{
    Console.WriteLine("No se encuentra el archivo " + msg);
}

