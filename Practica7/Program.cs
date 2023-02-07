// See https://aka.ms/new-console-template for more information

StreamWriter fichero;
string linea;
fichero = File.AppendText("prueba.txt");
fichero.WriteLine("añadimos texto al fichero, sino existe se crea");
fichero.Close();

StreamReader miLectura = File.OpenText("prueba.txt");
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